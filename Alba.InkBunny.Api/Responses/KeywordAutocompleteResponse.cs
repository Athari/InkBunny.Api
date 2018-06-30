using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal class KeywordAutocompleteResponse : BaseResponse
    {
        [JsonProperty("results")]
        public IList<KeywordSuggestion> Suggestions { get; set; }
    }
}