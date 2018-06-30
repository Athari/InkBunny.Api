using JetBrains.Annotations;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public interface IThumbnailHolder
    {
        SubmissionThumbnail MediumThumbnail { get; set; }
        SubmissionThumbnail MediumCustomThumbnail { get; set; }
        SubmissionThumbnail LargeThumbnail { get; set; }
        SubmissionThumbnail LargeCustomThumbnail { get; set; }
        SubmissionThumbnail HugeThumbnail { get; set; }
        SubmissionThumbnail HugeCustomThumbnail { get; set; }
    }
}