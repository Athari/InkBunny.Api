using System.Net;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public sealed class UserNameSuggestion
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

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
    }
}