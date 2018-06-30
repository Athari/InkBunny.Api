using Alba.InkBunny.Api.Converters;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal sealed class LoginResponse : BaseResponse
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("ratingsmask"), JsonConverter(typeof(RatingJsonConverter))]
        public Rating Rating { get; set; }
    }
}