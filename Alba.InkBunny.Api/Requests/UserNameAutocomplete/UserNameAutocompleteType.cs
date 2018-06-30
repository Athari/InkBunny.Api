using Alba.InkBunny.Api.Framework;
using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public enum UserNameAutocompleteType
    {
        [EnumMeta(JsonName = "start")]
        StartsWith,
        [EnumMeta(JsonName = "any")]
        Contains,
    }
}