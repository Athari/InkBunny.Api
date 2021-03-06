﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Alba.InkBunny.Api.Diagnostics;
using Alba.InkBunny.Api.Framework;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public class InkBunnyClient : IDisposable
    {
        public static readonly Uri BaseUri = new Uri("https://inkbunny.net/");

        private string _userAgentName;
        private string _userAgentVersion;

        public HttpClient HttpClient { get; }
        public ClientSession Session { get; } = new ClientSession();

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
                        new ProductInfoHeaderValue(_userAgentName ?? "Unknown", _userAgentVersion ?? ""),
                        new ProductInfoHeaderValue("(through-Alba.InkBunny.Api)"),
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
        public async Task LoginAsync(string name, string password)
        {
            var response = await RequestAsync<LoginResponse>("login", new KeyValueCollection(2) {
                ["username"] = name,
                ["password"] = password,
            });
            response.EnsureSuccess();
            Session.SessionId = response.SessionId;
            Session.UserId = response.UserId;
            Session.UserRating = response.Rating;
        }

        /// <summary>
        /// All queries to the API must be sent with a valid Session ID (SID). An SID is returned as a string called “sid” when you successfully log in to the API using the Login script. The SID identifies your session and contains all the properties and settings of the logged in user.<br/>
        /// You should logout if you do not expect to reuse a session. Session IDs typically remain valid for several days after their last use; so if you plan to access the site regularly, you should cache the SID, and only re-login if you receive an invalid SID error (code 2) when attempting to use it. This is preferable to caching login credentials.
        /// </summary>
        public Task LoginGuestAsync() => LoginAsync("guest", "");

        /// <summary>
        /// Log out of a session and destroy the temporary session data associated with the Session ID (sid). 
        /// </summary>
        public async Task LogoutAsync()
        {
            var response = await RequestAsync<BaseResponse>("logout", new KeyValueCollection(1) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
            Session.SessionId = "";
            Session.UserId = -1;
            Session.UserRating = Rating.None;
        }

        /// <summary>
        /// This script allows GUEST users to change their rating choice. By default, Guest users cannot see items with Mature (for sexual content) or Adult ratings.<br/>
        /// If you use this script to change rating settings for a logged in registered member, it will affect the current session only. The changes to their allowed ratings will not be saved to their account.<br/>
        /// Members can still choose to block their work from Guest users, regardless of the Guests' rating choice, so some work may still not appear for Guests even with all rating options turned on.
        /// </summary>
        /// <param name="rating">Show images with this rating.</param>
        public async Task SetUserRatingAsync(Rating rating)
        {
            var response = await RequestAsync<BaseResponse>("userrating", new KeyValueCollection(5) {
                ["sid"] = Session.SessionId,
                ["tag[2]"] = ((rating & Rating.MatureNudity) != 0).ToYesNo(),
                ["tag[3]"] = ((rating & Rating.MatureViolence) != 0).ToYesNo(),
                ["tag[4]"] = ((rating & Rating.AdultSex) != 0).ToYesNo(),
                ["tag[5]"] = ((rating & Rating.AdultViolence) != 0).ToYesNo(),
            });
            response.EnsureSuccess();
        }

        public async Task<SearchResponse> SearchSubmissionsAsync(SearchRequest request, int pageIndex = 1)
        {
            var response = await RequestAsync<SearchResponse>("search", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
                ["page"] = pageIndex.ToStringInv(),
            });
            response.EnsureSuccess();
            return response;
        }

        public async Task<SearchResponse> SearchSubmissionsFirstAsync(SearchRequest request, int pageIndex = 1)
        {
            var response = await RequestAsync<SearchResponse>("search", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
                ["get_rid"] = true.ToYesNo(),
                ["page"] = pageIndex.ToStringInv(),
            });
            response.EnsureSuccess();
            request.RequestId = response.RequestId;
            return response;
        }

        public async Task<SearchResponse> SearchSubmissionsNextAsync(SearchRequest request, int pageIndex)
        {
            var response = await RequestAsync<SearchResponse>("search", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
                ["rid"] = request.RequestId,
                ["page"] = pageIndex.ToStringInv(),
            });
            response.EnsureSuccess();
            return response;
        }

        public async Task<IList<Submission>> GetSubmissionsAsync(IList<Submission> submissions,
            SubmissionIncludeData includeData = SubmissionIncludeData.Default)
        {
            var request = new GetSubmissionsRequest {
                Submissions = submissions,
                IncludeData = includeData,
            };
            var response = await RequestAsync<SubmissionsReponse>("submissions", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
            return response.Submissions;
        }

        public async Task GetSubmissionFavingUsersAsync(Submission submission)
        {
            var request = new BasicSubmissionRequest(submission.Id);
            var response = await RequestAsync<FavingUsersResponse>("submissionfavingusers", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
            submission.FavingUsers = response.FavingUsers;
        }

        public async Task DeleteSubmissionAsync(int submissionId)
        {
            var request = new BasicSubmissionRequest(submissionId);
            var response = await RequestAsync<BaseResponse>("delsubmission", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
        }

        public async Task DeleteSubmissionPageAsync(int submissionPageId)
        {
            var request = new BasicSubmissionPageRequest(submissionPageId);
            var response = await RequestAsync<BaseResponse>("delfile", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
        }

        public async Task SetSubmissionPageOrderAsync(int submissionPageId, int order)
        {
            var request = new SetSubmissionPageOrderRequest(submissionPageId) { Order = order };
            var response = await RequestAsync<BaseResponse>("reorderfile", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
        }

        public async Task<IList<UserLink>> GetWatchedUsersAsync(WatchedUsersOrderBy orderBy = WatchedUsersOrderBy.WatchTime, int? limit = null)
        {
            var request = new WatchedUsersRequest {
                OrderBy = orderBy,
                Limit = limit,
            };
            var response = await RequestAsync<WatchedUsersResponse>("watchlist", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
            return response.WatchedUsers;
        }

        public async Task<IList<KeywordSuggestion>> GetKeywordAutocompleteAsync(string keyword,
            Rating rating = Rating.General, bool underscoreSpaces = false)
        {
            var request = new KeywordAutocompleteRequest {
                Keyword = keyword,
                Rating = rating,
                UnderscoreSpaces = underscoreSpaces,
            };
            var response = await RequestAsync<KeywordAutocompleteResponse>("search_autosuggest", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
            return response.Suggestions;
        }

        public async Task<IList<UserNameSuggestion>> GetUserNameAutocompleteAsync(string userName, UserNameAutocompleteType matchType)
        {
            var request = new UserNameAutocompleteRequest {
                UserName = userName,
                MatchType = matchType,
            };
            var response = await RequestAsync<UserNameAutocompleteResponse>("username_autosuggest", new KeyValueCollection(request) {
                ["sid"] = Session.SessionId,
            });
            response.EnsureSuccess();
            return response.Suggestions;
        }

        private async Task<TResponse> RequestAsync<TResponse>(string apiName, KeyValueCollection queryArguments, TResponse response = null)
            where TResponse : BaseResponse
        {
            bool isVerbose = InkBunnyApiTraceSources.Net.Switch.ShouldTrace(TraceEventType.Verbose);

            using (var requestContent = new MultipartFormDataContent())
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"/api_{apiName}.php")) {
                foreach (var queryArgument in queryArguments.Where(a => a.Value != null))
                    requestContent.Add(new StringContent(queryArgument.Value), queryArgument.Key);
                if (isVerbose) {
                    string argumentsString = queryArguments.Where(a => a.Value != null).Select(a => $"{a.Key}={a.Value}").JoinString("\n");
                    InkBunnyApiTraceSources.Net.TraceEvent(TraceEventType.Verbose, 1,
                        $"Request {requestMessage.Method} {requestMessage.RequestUri}\n{argumentsString}");
                }
                requestMessage.Content = requestContent;
                using (var responseMessage = await HttpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead)) {
                    responseMessage.EnsureSuccessStatusCode();

                    if (isVerbose) {
                        string json = await responseMessage.Content.ReadAsStringAsync();
                        string formattedJson = JObject.Parse(json).ToString(Formatting.Indented);
                        InkBunnyApiTraceSources.Net.TraceEvent(TraceEventType.Verbose, 2,
                            $"Response {requestMessage.Method} {requestMessage.RequestUri}\n{formattedJson}");
                        if (response == null)
                            response = JsonConvert.DeserializeObject<TResponse>(json);
                        else
                            JsonConvert.PopulateObject(json, response);
                        return response;
                    }
                    else {
                        using (var contentStream = await responseMessage.Content.ReadAsStreamAsync())
                        using (var streamReader = new StreamReader(contentStream, Encoding.UTF8))
                        using (var jsonReader = new JsonTextReader(streamReader)) {
                            var serializer = new JsonSerializer();
                            if (response == null)
                                response = serializer.Deserialize<TResponse>(jsonReader);
                            else
                                serializer.Populate(jsonReader, response);
                            return response;
                        }
                    }
                }
            }
        }

        public void Dispose()
        {
            HttpClient?.Dispose();
        }

        public override string ToString() => $"{GetType().Name}: {Session}";
    }
}