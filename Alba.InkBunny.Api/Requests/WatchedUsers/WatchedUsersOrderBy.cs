using Alba.InkBunny.Api.Framework;
using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public enum WatchedUsersOrderBy
    {
        [EnumMeta(JsonName = "alphabetical")]
        UserName,
        [EnumMeta(JsonName = "create_datetime")]
        WatchTime,
    }
}