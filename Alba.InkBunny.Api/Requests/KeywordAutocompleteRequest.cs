using Alba.InkBunny.Api.Converters;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal class KeywordAutocompleteRequest
    {
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("ratingsmask"), JsonConverter(typeof(RatingJsonConverter))]
        public Rating Rating { get; set; }

        [JsonProperty("underscorespaces"), JsonConverter(typeof(BooleanYesNoConverter))]
        public bool UnderscoreSpaces { get; set; }
    }
}