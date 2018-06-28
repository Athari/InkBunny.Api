using System.Collections.Generic;

namespace Alba.InkBunny.Api.Framework
{
    internal static class EnumerableExts
    {
        public static string JoinString<T>(this IEnumerable<T> @this, string separator) => string.Join(separator, @this);
        public static string JoinString(this IEnumerable<string> @this, string separator) => string.Join(separator, @this);
    }
}