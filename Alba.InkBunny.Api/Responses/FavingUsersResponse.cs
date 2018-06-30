using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal class FavingUsersResponse : BaseResponse
    {
        [JsonProperty("favingusers")]
        public IList<UserLink> FavingUsers { get; set; }
    }
}