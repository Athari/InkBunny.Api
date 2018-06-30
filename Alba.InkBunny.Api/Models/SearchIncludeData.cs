using System;
using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [Flags]
    [PublicAPI]
    public enum SearchIncludeData
    {
        None = 0,

        SubmissionIds = 1 << 0,
        Submissions = 1 << 1,
        Keywords = 1 << 2,

        Default = Submissions,
        All = SubmissionIds | Submissions | Keywords,
    }

    internal static class SearchQueryModeExts
    {
        public static bool Has(this SearchIncludeData @this, SearchIncludeData value) => (@this & value) == value;
    }
}