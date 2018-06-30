using System.Net;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public sealed class KeywordSuggestion
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonIgnore]
        public string Value => WebUtility.HtmlDecode(ValueHtml);

        [JsonProperty("value")]
        public string ValueHtml { get; set; }

        [JsonIgnore]
        public string SingleWord => WebUtility.HtmlDecode(SingleWordHtml);

        [JsonProperty("singleword")]
        public string SingleWordHtml { get; set; }

        [JsonIgnore]
        public string SearchTerm => WebUtility.HtmlDecode(SearchTermHtml);

        [JsonProperty("searchterm")]
        public string SearchTermHtml { get; set; }

        [JsonProperty("submissions_count")]
        public int SubmissionCount { get; set; }
    }
}