namespace Alba.InkBunny.Api.Framework
{
    internal static class ValueExts
    {
        public static string ToYesNo(this bool @this) => @this ? "yes" : "no";
    }
}