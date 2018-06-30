using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public sealed class LogoutResponse : BaseResponse
    {
        [JsonProperty("logout")]
        public string LogoutMessage { get; set; }
    }
}