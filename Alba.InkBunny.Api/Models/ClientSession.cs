using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public sealed class ClientSession
    {
        [JsonProperty]
        public string SessionId { get; set; } = "";

        [JsonProperty]
        public int UserId { get; set; } = -1;

        [JsonProperty]
        public Rating UserRating { get; set; } = Rating.None;

        [JsonIgnore]
        public bool IsLoggedIn => UserId != -1;

        public string Serialize() => JsonConvert.SerializeObject(this);
        public static ClientSession Deserialize(string s) => JsonConvert.DeserializeObject<ClientSession>(s);

        public override string ToString() => IsLoggedIn ? $"{UserId}:{SessionId}" : "Unauthorized";
    }
}