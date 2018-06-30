using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Alba.InkBunny.Api.Framework;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public class InkBunnyClient : IDisposable
    {
        public static readonly Uri BaseUri = new Uri("https://inkbunny.net/");

        private string _userAgentName;
        private string _userAgentVersion;

        public HttpClient HttpClient { get; }
        public string SessionId { get; private set; } = "";
        public int UserId { get; private set; } = -1;
        public Rating UserRating { get; private set; } = Rating.General;

        public InkBunnyClient(HttpClientHandler httpClientHandler = null)
        {
            HttpClient = new HttpClient(httpClientHandler ?? new HttpClientHandler {
                AllowAutoRedirect = true,
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip,
            }) {
                BaseAddress = BaseUri,
                DefaultRequestHeaders = {
                    Referrer = BaseUri,
                    UserAgent = {
                        new ProductInfoHeaderValue(_userAgentName ?? "", _userAgentVersion ?? ""),
                        new ProductInfoHeaderValue("through Alba.InkBunny.Api"),
                    }
                }
            };
        }

        /// <summary> 
        /// All queries to the API must be sent with a valid Session ID (SID). An SID is returned as a string called “sid” when you successfully log in to the API using the Login script. The SID identifies your session and contains all the properties and settings of the logged in user.<br/>
        /// User accounts are only accessible for login via the API if “Enable API Access” is enabled in the user's Account Settings https://inkbunny.net/account.php <br/>
        /// You should logout if you do not expect to reuse a session. Session IDs typically remain valid for several days after their last use; so if you plan to access the site regularly, you should cache the SID, and only re-login if you receive an invalid SID error (code 2) when attempting to use it. This is preferable to caching login credentials.
        /// </summary>
        /// <param name="name"> Username of account to log in to. Case-insensitive.</param>
        /// <param name="password">Password of account to log in to. Case sensitive.</param>
        public async Task<LoginResponse> LoginAsync(string name, string password)
        {
            var login = await RequestAsync<LoginResponse>("login", new KeyValueCollection(2) {
                ["username"] = name,
                ["password"] = password,
            });
            login.EnsureSuccess();
            SessionId = login.SessionId;
            UserId = login.UserId;
            UserRating = login.Rating;
            return login;
        }

        /// <summary>
        /// All queries to the API must be sent with a valid Session ID (SID). An SID is returned as a string called “sid” when you successfully log in to the API using the Login script. The SID identifies your session and contains all the properties and settings of the logged in user.<br/>
        /// You should logout if you do not expect to reuse a session. Session IDs typically remain valid for several days after their last use; so if you plan to access the site regularly, you should cache the SID, and only re-login if you receive an invalid SID error (code 2) when attempting to use it. This is preferable to caching login credentials.
        /// </summary>
        public Task<LoginResponse> LoginGuestAsync() => LoginAsync("guest", "");

        /// <summary>
        /// Log out of a session and destroy the temporary session data associated with the Session ID (sid). 
        /// </summary>
        public async Task<LogoutResponse> LogoutAsync()
        {
            var logout = await RequestAsync<LogoutResponse>("logout", new KeyValueCollection(1) {
                ["sid"] = SessionId,
            });
            logout.EnsureSuccess();
            SessionId = "";
            UserId = -1;
            UserRating = Rating.General;
            return logout;
        }

        /// <summary>
        /// This script allows GUEST users to change their rating choice. By default, Guest users cannot see items with Mature (for sexual content) or Adult ratings.<br/>
        /// If you use this script to change rating settings for a logged in registered member, it will affect the current session only. The changes to their allowed ratings will not be saved to their account.<br/>
        /// Members can still choose to block their work from Guest users, regardless of the Guests' rating choice, so some work may still not appear for Guests even with all rating options turned on.
        /// </summary>
        /// <param name="rating">Show images with this rating.</param>
        public async Task<BaseResponse> SetUserRatingAsync(Rating rating)
        {
            var userRating = await RequestAsync<BaseResponse>("userrating", new KeyValueCollection(5) {
                ["sid"] = SessionId,
                ["tag[2]"] = ((rating & Rating.MatureNudity) != 0).ToYesNo(),
                ["tag[3]"] = ((rating & Rating.MatureViolence) != 0).ToYesNo(),
                ["tag[4]"] = ((rating & Rating.AdultSex) != 0).ToYesNo(),
                ["tag[5]"] = ((rating & Rating.AdultViolence) != 0).ToYesNo(),
            });
            userRating.EnsureSuccess();
            return userRating;
        }

        public async Task<SearchResponse> SearchSubmissionsAsync(SearchQuery query, int pageIndex)
        {
            var arg = KeyValueCollection.FromJson(query);
            arg.AddRange(new KeyValueCollection(2) {
                ["sid"] = SessionId,
                ["page"] = pageIndex.ToStringInv(),
            });
            var search = await RequestAsync<SearchResponse>("search", arg);
            search.EnsureSuccess();
            return search;
        }

        public async Task<SearchResponse> SearchSubmissionsFirstAsync(SearchQuery query, int pageIndex)
        {
            var arg = KeyValueCollection.FromJson(query);
            arg.AddRange(new KeyValueCollection(3) {
                ["sid"] = SessionId,
                ["get_rid"] = true.ToYesNo(),
                ["page"] = pageIndex.ToStringInv(),
            });
            var search = await RequestAsync<SearchResponse>("search", arg);
            search.EnsureSuccess();
            query.RequestId = search.RequestId;
            return search;
        }

        public async Task<SearchResponse> SearchSubmissionsNextAsync(SearchQuery query, int pageIndex)
        {
            var arg = KeyValueCollection.FromJson(query);
            arg.AddRange(new KeyValueCollection(3) {
                ["sid"] = SessionId,
                ["rid"] = query.RequestId,
                ["page"] = pageIndex.ToStringInv(),
            });
            var search = await RequestAsync<SearchResponse>("search", arg);
            search.EnsureSuccess();
            return search;
        }

        public async Task<SubmissionsReponse> GetSubmissionsAsync(SubmissionsQuery query)
        {
            var arg = KeyValueCollection.FromJson(query);
            arg.AddRange(new KeyValueCollection(1) {
                ["sid"] = SessionId,
            });
            var submissions = await RequestAsync<SubmissionsReponse>("submissions", arg);
            submissions.EnsureSuccess();
            return submissions;
        }

        private async Task<T> RequestAsync<T>(string api, KeyValueCollection arguments)
            where T : BaseResponse
        {
            using (var request = new MultipartFormDataContent()) {
                foreach (KeyValuePair<string, string> argument in arguments.Where(a => a.Value != null))
                    request.Add(new StringContent(argument.Value), argument.Key);
                using (HttpResponseMessage response = await HttpClient.PostAsync($"/api_{api}.php", request)) {
                    response.EnsureSuccessStatusCode();
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                }
            }
        }

        public void Dispose()
        {
            HttpClient?.Dispose();
        }
    }
}