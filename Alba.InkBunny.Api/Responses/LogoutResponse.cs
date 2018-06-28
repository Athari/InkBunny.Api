using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public class LogoutResponse : BaseResponse
    {
        [JsonProperty("logout")]
        public string LogoutMessage { get; set; }
    }
}