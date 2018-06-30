using System;
using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [Flags]
    [PublicAPI]
    public enum SubmissionIncludeData
    {
        None = 0,

        Description = 1 << 0,
        DescriptionHtml = 1 << 1,
        Writing = 1 << 2,
        WritingHtml = 1 << 3,
        Pools = 1 << 4,

        Default = None,
        All = Description | DescriptionHtml | Writing | WritingHtml | Pools,
    }

    internal static class SubmissionIncludeDataExts
    {
        public static bool Has(this SubmissionIncludeData @this, SubmissionIncludeData value) => (@this & value) == value;
    }
}