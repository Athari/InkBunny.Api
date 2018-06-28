using System;

namespace Alba.InkBunny.Api
{
    [Flags]
    public enum SearchTextField
    {
        None = 0,

        Keywords = 1 << 0,
        Title = 1 << 1,
        Description = 1 << 2,
        MD5 = 1 << 3,

        Default = Keywords,
        All = Keywords | Title | Description | MD5,
    }

    internal static class SearchTextFieldsExts
    {
        public static bool Has(this SearchTextField @this, SearchTextField value) => (@this & value) == value;
    }
}