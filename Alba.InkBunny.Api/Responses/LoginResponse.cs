using Alba.InkBunny.Api.Converters;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public class LoginResponse : BaseResponse
    {
        [JsonProperty("ratingsmask"), JsonConverter(typeof(RatingJsonConverter))]
        public Rating Rating { get; set; }
    }
}