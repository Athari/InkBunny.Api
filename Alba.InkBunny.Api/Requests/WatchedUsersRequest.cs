using Alba.InkBunny.Api.Converters;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public class WatchedUsersRequest
    {
        [JsonProperty("orderby"), JsonConverter(typeof(EnumMetaNameConverter<WatchedUsersOrderBy>))]
        public WatchedUsersOrderBy OrderBy { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }
}