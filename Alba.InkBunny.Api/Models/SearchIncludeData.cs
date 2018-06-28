using System;

namespace Alba.InkBunny.Api
{
    [Flags]
    public enum SearchIncludeData
    {
        None = 0,

        SubmissionIds = 1 << 0,
        Submissions = 1 << 1,
        Keywords = 1 << 2,

        Default = Submissions,
    }

    internal static class SearchQueryModeExts
    {
        public static bool Has(this SearchIncludeData @this, SearchIncludeData value) => (@this & value) == value;
    }
}