using Alba.InkBunny.Api.Converters;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public class UserNameAutocompleteRequest
    {
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("searchtype"), JsonConverter(typeof(EnumMetaNameConverter<UserNameAutocompleteType>))]
        public UserNameAutocompleteType MatchType { get; set; }
    }
}