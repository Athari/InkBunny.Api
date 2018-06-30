using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal class UserNameAutocompleteResponse : BaseResponse
    {
        [JsonProperty("results")]
        public IList<UserNameSuggestion> Suggestions { get; set; }
    }
}