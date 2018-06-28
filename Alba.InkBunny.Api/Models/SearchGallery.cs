using Alba.InkBunny.Api.Framework;

namespace Alba.InkBunny.Api
{
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