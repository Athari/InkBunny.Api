using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public sealed class ClientSession
    {
        [JsonProperty]
        public string SessionId { get; set; } = "";

        [JsonProperty]
        public int UserId { get; set; } = -1;

        [JsonProperty]
        public Rating UserRating { get; set; } = Rating.None;

        public string Serialize() => JsonConvert.SerializeObject(this);
        public static ClientSession Deserialize(string s) => JsonConvert.DeserializeObject<ClientSession>(s);
    }
}