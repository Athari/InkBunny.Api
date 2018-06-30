using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal sealed class LogoutResponse : BaseResponse
    {
        [JsonProperty("logout")]
        public string LogoutMessage { get; set; }
    }
}