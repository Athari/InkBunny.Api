using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal class WatchedUsersResponse : BaseResponse
    {
        [JsonProperty("watches")]
        public IList<UserLink> WatchedUsers { get; set; }
    }
}