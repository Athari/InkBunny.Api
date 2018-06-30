using Alba.InkBunny.Api.Framework;
using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public enum SearchGallery
    {
        [EnumMeta(JsonName = "no")]
        Main,
        [EnumMeta(JsonName = "only")]
        Scraps,
        [EnumMeta(JsonName = "both")]
        Both,
    }
}