using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Alba.InkBunny.Api.Diagnostics;
using static System.Console;

namespace Alba.InkBunny.Api.ConsoleTest
{
    public class Program
    {
        [SuppressMessage("ReSharper", "AsyncConverter.AsyncMethodNamingHighlighting")]
        public static Task Main(string[] args) => new Program().MainAsync(args);

        public async Task MainAsync(string[] args)
        {
            try {
                EnableLogging();
                await ShowGalleryAsync();
                WriteLine("Done!");
            }
            catch (Exception e) {
                WriteLine("ERROR!");
                WriteLine(e);
            }
            if (Debugger.IsAttached) {
                WriteLine("Press ENTER to continue...");
                ReadLine();
            }
        }

        private void EnableLogging()
        {
            InkBunnyApiTraceSources.Net.Switch.Level = SourceLevels.All;
            InkBunnyApiTraceSources.Net.Listeners.Add(new ConsoleTraceListener());
        }

        private async Task ShowGalleryAsync()
        {
            var client = new InkBunnyClient(new HttpClientHandler {
                Proxy = new WebProxy("proxy.antizapret.prostovpn.org", 3128)
            });

            WriteLine("Logging in...");
            await client.LoginGuestAsync();
            WriteLine($"Logged in: {client.Session.Serialize()}");

            WriteLine("Setting rating...");
            await client.SetUserRatingAsync(Rating.All);
            WriteLine("Set rating");

            WriteLine("Searching user submissions...");
            var searchSingleUserRequest = new SearchRequest {
                IncludeData = SearchIncludeData.All,
                UserName = "Athari",
                OrderBy = SearchOrderBy.Views,
                PageSize = 100,
            };
            var searchSingle = await client.SearchSubmissionsAsync(searchSingleUserRequest);
            WriteLine($"Searched user submissions:\n{string.Join("\n", searchSingle.Submissions.Select(s => $"  {s}"))}.");

            WriteLine("Searching user submissions: init...");
            var searchMultUserRequest = new SearchRequest {
                IncludeData = SearchIncludeData.None,
                UserName = "Athari",
                OrderBy = SearchOrderBy.Views,
                PageSize = 2,
            };
            var searchMult = await client.SearchSubmissionsFirstAsync(searchMultUserRequest);
            WriteLine($"Searched user submissions: init: total {searchMult.SubmissionCount}, request {searchMult.RequestId} ({searchMult.RequestIdTimeToLive})");
            var allSubmissions = new List<Submission>();
            for (int page = 1; page <= searchMult.PageCount; page++) {
                searchMultUserRequest.IncludeData = SearchIncludeData.SubmissionIds;
                WriteLine($"Searching user submissions: page {page}...");
                var search = await client.SearchSubmissionsNextAsync(searchMultUserRequest, page);
                WriteLine($"Searched user submissions: page {page}");
                WriteLine($"Getting user submissions: page {page}...");
                var submissions = await client.GetSubmissionsAsync(search.Submissions, SubmissionIncludeData.All);
                allSubmissions.AddRange(submissions);
                WriteLine($"Got user submissions: page {page}");
            }

            WriteLine("Listing all submissions...");
            foreach (Submission submission in allSubmissions) {
                WriteLine($"Title: {submission}");
                WriteLine($"Description: {submission.Description}");
                WriteLine($"Pools: {(submission.Pools != null ? string.Join(", ", submission.Pools) : "none")}");
            }
            WriteLine("Listed all submissions");

            WriteLine("Logging out...");
            await client.LogoutAsync();
            WriteLine("Logout");
        }
    }
}