using System;
using System.Globalization;

namespace Alba.InkBunny.Api.Framework
{
    internal static class ConvertibleExts
    {
        public static object ToType(this IConvertible @this, Type conversionType) => @this.ToType(conversionType, CultureInfo.CurrentCulture);
        public static object ToTypeInv(this IConvertible @this, Type conversionType) => @this.ToType(conversionType, CultureInfo.InvariantCulture);
        public static string ToStringInv(this IConvertible @this) => @this.ToString(CultureInfo.InvariantCulture);
    }
}