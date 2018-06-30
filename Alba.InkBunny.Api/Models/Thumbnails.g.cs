//
// Generated file. Do not edit manually.
//

using System;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal partial class SubmissionRaw
    {
        [JsonProperty("file_name")]
        public string PrimaryPageFileName { get; set; }

        [JsonProperty("mimetype")]
        public string PrimaryPageMimeType { get; set; }

        [JsonProperty("file_url_preview")]
        public Uri PrimaryPagePreviewFileUri { get; set; }

        [JsonProperty("file_url_screen")]
        public Uri PrimaryPageScreenFileUri { get; set; }

        [JsonProperty("file_url_full")]
        public Uri PrimaryPageFullFileUri { get; set; }

        [JsonProperty("thumbnail_url_medium_noncustom")]
        public Uri PrimaryPageMediumThumbnailUri { get; set; }

        [JsonProperty("thumb_medium_noncustom_x")]
        public int? PrimaryPageMediumThumbnailWidth { get; set; }

        [JsonProperty("thumb_medium_noncustom_y")]
        public int? PrimaryPageMediumThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_medium")]
        public Uri PrimaryPageMediumCustomThumbnailUri { get; set; }

        [JsonProperty("thumb_medium_x")]
        public int? PrimaryPageMediumCustomThumbnailWidth { get; set; }

        [JsonProperty("thumb_medium_y")]
        public int? PrimaryPageMediumCustomThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_large_noncustom")]
        public Uri PrimaryPageLargeThumbnailUri { get; set; }

        [JsonProperty("thumb_large_noncustom_x")]
        public int? PrimaryPageLargeThumbnailWidth { get; set; }

        [JsonProperty("thumb_large_noncustom_y")]
        public int? PrimaryPageLargeThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_large")]
        public Uri PrimaryPageLargeCustomThumbnailUri { get; set; }

        [JsonProperty("thumb_large_x")]
        public int? PrimaryPageLargeCustomThumbnailWidth { get; set; }

        [JsonProperty("thumb_large_y")]
        public int? PrimaryPageLargeCustomThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_huge_noncustom")]
        public Uri PrimaryPageHugeThumbnailUri { get; set; }

        [JsonProperty("thumb_huge_noncustom_x")]
        public int? PrimaryPageHugeThumbnailWidth { get; set; }

        [JsonProperty("thumb_huge_noncustom_y")]
        public int? PrimaryPageHugeThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_huge")]
        public Uri PrimaryPageHugeCustomThumbnailUri { get; set; }

        [JsonProperty("thumb_huge_x")]
        public int? PrimaryPageHugeCustomThumbnailWidth { get; set; }

        [JsonProperty("thumb_huge_y")]
        public int? PrimaryPageHugeCustomThumbnailHeight { get; set; }

        [JsonProperty("latest_file_name")]
        public string LatestPageFileName { get; set; }

        [JsonProperty("latest_mimetype")]
        public string LatestPageMimeType { get; set; }

        [JsonProperty("file_latest_url_preview")]
        public Uri LatestPagePreviewFileUri { get; set; }

        [JsonProperty("file_latest_url_screen")]
        public Uri LatestPageScreenFileUri { get; set; }

        [JsonProperty("file_latest_url_full")]
        public Uri LatestPageFullFileUri { get; set; }

        [JsonProperty("latest_thumbnail_url_medium_noncustom")]
        public Uri LatestPageMediumThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_medium_noncustom_x")]
        public int? LatestPageMediumThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_medium_noncustom_y")]
        public int? LatestPageMediumThumbnailHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_medium")]
        public Uri LatestPageMediumCustomThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_medium_x")]
        public int? LatestPageMediumCustomThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_medium_y")]
        public int? LatestPageMediumCustomThumbnailHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_large_noncustom")]
        public Uri LatestPageLargeThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_large_noncustom_x")]
        public int? LatestPageLargeThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_large_noncustom_y")]
        public int? LatestPageLargeThumbnailHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_large")]
        public Uri LatestPageLargeCustomThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_large_x")]
        public int? LatestPageLargeCustomThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_large_y")]
        public int? LatestPageLargeCustomThumbnailHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_huge_noncustom")]
        public Uri LatestPageHugeThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_huge_noncustom_x")]
        public int? LatestPageHugeThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_huge_noncustom_y")]
        public int? LatestPageHugeThumbnailHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_huge")]
        public Uri LatestPageHugeCustomThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_huge_x")]
        public int? LatestPageHugeCustomThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_huge_y")]
        public int? LatestPageHugeCustomThumbnailHeight { get; set; }

        private void CopyToNormal(Submission other)
        {
            other.PrimaryPage = new SubmissionPage {
                FileName = PrimaryPageFileName,
                MimeType = PrimaryPageMimeType,
                PreviewFile = new SubmissionFile {
                    Uri = PrimaryPagePreviewFileUri,
                },
                ScreenFile = new SubmissionFile {
                    Uri = PrimaryPageScreenFileUri,
                },
                FullFile = new SubmissionFile {
                    Uri = PrimaryPageFullFileUri,
                },
                MediumThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageMediumThumbnailUri,
                    Width = PrimaryPageMediumThumbnailWidth,
                    Height = PrimaryPageMediumThumbnailHeight,
                },
                MediumCustomThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageMediumCustomThumbnailUri,
                    Width = PrimaryPageMediumCustomThumbnailWidth,
                    Height = PrimaryPageMediumCustomThumbnailHeight,
                },
                LargeThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageLargeThumbnailUri,
                    Width = PrimaryPageLargeThumbnailWidth,
                    Height = PrimaryPageLargeThumbnailHeight,
                },
                LargeCustomThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageLargeCustomThumbnailUri,
                    Width = PrimaryPageLargeCustomThumbnailWidth,
                    Height = PrimaryPageLargeCustomThumbnailHeight,
                },
                HugeThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageHugeThumbnailUri,
                    Width = PrimaryPageHugeThumbnailWidth,
                    Height = PrimaryPageHugeThumbnailHeight,
                },
                HugeCustomThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageHugeCustomThumbnailUri,
                    Width = PrimaryPageHugeCustomThumbnailWidth,
                    Height = PrimaryPageHugeCustomThumbnailHeight,
                },
            };
            other.LatestPage = new SubmissionPage {
                FileName = LatestPageFileName,
                MimeType = LatestPageMimeType,
                PreviewFile = new SubmissionFile {
                    Uri = LatestPagePreviewFileUri,
                },
                ScreenFile = new SubmissionFile {
                    Uri = LatestPageScreenFileUri,
                },
                FullFile = new SubmissionFile {
                    Uri = LatestPageFullFileUri,
                },
                MediumThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageMediumThumbnailUri,
                    Width = LatestPageMediumThumbnailWidth,
                    Height = LatestPageMediumThumbnailHeight,
                },
                MediumCustomThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageMediumCustomThumbnailUri,
                    Width = LatestPageMediumCustomThumbnailWidth,
                    Height = LatestPageMediumCustomThumbnailHeight,
                },
                LargeThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageLargeThumbnailUri,
                    Width = LatestPageLargeThumbnailWidth,
                    Height = LatestPageLargeThumbnailHeight,
                },
                LargeCustomThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageLargeCustomThumbnailUri,
                    Width = LatestPageLargeCustomThumbnailWidth,
                    Height = LatestPageLargeCustomThumbnailHeight,
                },
                HugeThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageHugeThumbnailUri,
                    Width = LatestPageHugeThumbnailWidth,
                    Height = LatestPageHugeThumbnailHeight,
                },
                HugeCustomThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageHugeCustomThumbnailUri,
                    Width = LatestPageHugeCustomThumbnailWidth,
                    Height = LatestPageHugeCustomThumbnailHeight,
                },
            };
        }
    }

    public partial class Submission
    {
        private void CopyToRaw(SubmissionRaw other)
        {
            other.PrimaryPageFileName = PrimaryPage?.FileName ?? default;
            other.PrimaryPageMimeType = PrimaryPage?.MimeType ?? default;
            other.PrimaryPagePreviewFileUri = PrimaryPage?.PreviewFile?.Uri ?? default;
            other.PrimaryPageScreenFileUri = PrimaryPage?.ScreenFile?.Uri ?? default;
            other.PrimaryPageFullFileUri = PrimaryPage?.FullFile?.Uri ?? default;
            other.PrimaryPageMediumThumbnailUri = PrimaryPage?.MediumThumbnail?.Uri ?? default;
            other.PrimaryPageMediumThumbnailWidth = PrimaryPage?.MediumThumbnail?.Width ?? default;
            other.PrimaryPageMediumThumbnailHeight = PrimaryPage?.MediumThumbnail?.Height ?? default;
            other.PrimaryPageMediumCustomThumbnailUri = PrimaryPage?.MediumCustomThumbnail?.Uri ?? default;
            other.PrimaryPageMediumCustomThumbnailWidth = PrimaryPage?.MediumCustomThumbnail?.Width ?? default;
            other.PrimaryPageMediumCustomThumbnailHeight = PrimaryPage?.MediumCustomThumbnail?.Height ?? default;
            other.PrimaryPageLargeThumbnailUri = PrimaryPage?.LargeThumbnail?.Uri ?? default;
            other.PrimaryPageLargeThumbnailWidth = PrimaryPage?.LargeThumbnail?.Width ?? default;
            other.PrimaryPageLargeThumbnailHeight = PrimaryPage?.LargeThumbnail?.Height ?? default;
            other.PrimaryPageLargeCustomThumbnailUri = PrimaryPage?.LargeCustomThumbnail?.Uri ?? default;
            other.PrimaryPageLargeCustomThumbnailWidth = PrimaryPage?.LargeCustomThumbnail?.Width ?? default;
            other.PrimaryPageLargeCustomThumbnailHeight = PrimaryPage?.LargeCustomThumbnail?.Height ?? default;
            other.PrimaryPageHugeThumbnailUri = PrimaryPage?.HugeThumbnail?.Uri ?? default;
            other.PrimaryPageHugeThumbnailWidth = PrimaryPage?.HugeThumbnail?.Width ?? default;
            other.PrimaryPageHugeThumbnailHeight = PrimaryPage?.HugeThumbnail?.Height ?? default;
            other.PrimaryPageHugeCustomThumbnailUri = PrimaryPage?.HugeCustomThumbnail?.Uri ?? default;
            other.PrimaryPageHugeCustomThumbnailWidth = PrimaryPage?.HugeCustomThumbnail?.Width ?? default;
            other.PrimaryPageHugeCustomThumbnailHeight = PrimaryPage?.HugeCustomThumbnail?.Height ?? default;
            other.LatestPageFileName = LatestPage?.FileName ?? default;
            other.LatestPageMimeType = LatestPage?.MimeType ?? default;
            other.LatestPagePreviewFileUri = LatestPage?.PreviewFile?.Uri ?? default;
            other.LatestPageScreenFileUri = LatestPage?.ScreenFile?.Uri ?? default;
            other.LatestPageFullFileUri = LatestPage?.FullFile?.Uri ?? default;
            other.LatestPageMediumThumbnailUri = LatestPage?.MediumThumbnail?.Uri ?? default;
            other.LatestPageMediumThumbnailWidth = LatestPage?.MediumThumbnail?.Width ?? default;
            other.LatestPageMediumThumbnailHeight = LatestPage?.MediumThumbnail?.Height ?? default;
            other.LatestPageMediumCustomThumbnailUri = LatestPage?.MediumCustomThumbnail?.Uri ?? default;
            other.LatestPageMediumCustomThumbnailWidth = LatestPage?.MediumCustomThumbnail?.Width ?? default;
            other.LatestPageMediumCustomThumbnailHeight = LatestPage?.MediumCustomThumbnail?.Height ?? default;
            other.LatestPageLargeThumbnailUri = LatestPage?.LargeThumbnail?.Uri ?? default;
            other.LatestPageLargeThumbnailWidth = LatestPage?.LargeThumbnail?.Width ?? default;
            other.LatestPageLargeThumbnailHeight = LatestPage?.LargeThumbnail?.Height ?? default;
            other.LatestPageLargeCustomThumbnailUri = LatestPage?.LargeCustomThumbnail?.Uri ?? default;
            other.LatestPageLargeCustomThumbnailWidth = LatestPage?.LargeCustomThumbnail?.Width ?? default;
            other.LatestPageLargeCustomThumbnailHeight = LatestPage?.LargeCustomThumbnail?.Height ?? default;
            other.LatestPageHugeThumbnailUri = LatestPage?.HugeThumbnail?.Uri ?? default;
            other.LatestPageHugeThumbnailWidth = LatestPage?.HugeThumbnail?.Width ?? default;
            other.LatestPageHugeThumbnailHeight = LatestPage?.HugeThumbnail?.Height ?? default;
            other.LatestPageHugeCustomThumbnailUri = LatestPage?.HugeCustomThumbnail?.Uri ?? default;
            other.LatestPageHugeCustomThumbnailWidth = LatestPage?.HugeCustomThumbnail?.Width ?? default;
            other.LatestPageHugeCustomThumbnailHeight = LatestPage?.HugeCustomThumbnail?.Height ?? default;
        }
    }

    internal partial class SubmissionPageRaw
    {
        [JsonProperty("file_url_preview")]
        public Uri PreviewFileUri { get; set; }

        [JsonProperty("preview_size_x")]
        public int PreviewFileWidth { get; set; }

        [JsonProperty("preview_size_y")]
        public int PreviewFileHeight { get; set; }

        [JsonProperty("file_url_screen")]
        public Uri ScreenFileUri { get; set; }

        [JsonProperty("screen_size_x")]
        public int ScreenFileWidth { get; set; }

        [JsonProperty("screen_size_y")]
        public int ScreenFileHeight { get; set; }

        [JsonProperty("file_url_full")]
        public Uri FullFileUri { get; set; }

        [JsonProperty("full_size_x")]
        public int FullFileWidth { get; set; }

        [JsonProperty("full_size_y")]
        public int FullFileHeight { get; set; }

        [JsonProperty("thumbnail_url_medium_noncustom")]
        public Uri MediumThumbnailUri { get; set; }

        [JsonProperty("thumb_medium_noncustom_x")]
        public int? MediumThumbnailWidth { get; set; }

        [JsonProperty("thumb_medium_noncustom_y")]
        public int? MediumThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_medium")]
        public Uri MediumCustomThumbnailUri { get; set; }

        [JsonProperty("thumb_medium_x")]
        public int? MediumCustomThumbnailWidth { get; set; }

        [JsonProperty("thumb_medium_y")]
        public int? MediumCustomThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_large_noncustom")]
        public Uri LargeThumbnailUri { get; set; }

        [JsonProperty("thumb_large_noncustom_x")]
        public int? LargeThumbnailWidth { get; set; }

        [JsonProperty("thumb_large_noncustom_y")]
        public int? LargeThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_large")]
        public Uri LargeCustomThumbnailUri { get; set; }

        [JsonProperty("thumb_large_x")]
        public int? LargeCustomThumbnailWidth { get; set; }

        [JsonProperty("thumb_large_y")]
        public int? LargeCustomThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_huge_noncustom")]
        public Uri HugeThumbnailUri { get; set; }

        [JsonProperty("thumb_huge_noncustom_x")]
        public int? HugeThumbnailWidth { get; set; }

        [JsonProperty("thumb_huge_noncustom_y")]
        public int? HugeThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_huge")]
        public Uri HugeCustomThumbnailUri { get; set; }

        [JsonProperty("thumb_huge_x")]
        public int? HugeCustomThumbnailWidth { get; set; }

        [JsonProperty("thumb_huge_y")]
        public int? HugeCustomThumbnailHeight { get; set; }

        private void CopyToNormal(SubmissionPage other)
        {
            other.PreviewFile = new SubmissionFile {
                Uri = PreviewFileUri,
                Width = PreviewFileWidth,
                Height = PreviewFileHeight,
            };
            other.ScreenFile = new SubmissionFile {
                Uri = ScreenFileUri,
                Width = ScreenFileWidth,
                Height = ScreenFileHeight,
            };
            other.FullFile = new SubmissionFile {
                Uri = FullFileUri,
                Width = FullFileWidth,
                Height = FullFileHeight,
            };
            other.MediumThumbnail = new SubmissionThumbnail {
                Uri = MediumThumbnailUri,
                Width = MediumThumbnailWidth,
                Height = MediumThumbnailHeight,
            };
            other.MediumCustomThumbnail = new SubmissionThumbnail {
                Uri = MediumCustomThumbnailUri,
                Width = MediumCustomThumbnailWidth,
                Height = MediumCustomThumbnailHeight,
            };
            other.LargeThumbnail = new SubmissionThumbnail {
                Uri = LargeThumbnailUri,
                Width = LargeThumbnailWidth,
                Height = LargeThumbnailHeight,
            };
            other.LargeCustomThumbnail = new SubmissionThumbnail {
                Uri = LargeCustomThumbnailUri,
                Width = LargeCustomThumbnailWidth,
                Height = LargeCustomThumbnailHeight,
            };
            other.HugeThumbnail = new SubmissionThumbnail {
                Uri = HugeThumbnailUri,
                Width = HugeThumbnailWidth,
                Height = HugeThumbnailHeight,
            };
            other.HugeCustomThumbnail = new SubmissionThumbnail {
                Uri = HugeCustomThumbnailUri,
                Width = HugeCustomThumbnailWidth,
                Height = HugeCustomThumbnailHeight,
            };
        }
    }

    public partial class SubmissionPage
    {
        private void CopyToRaw(SubmissionPageRaw other)
        {
            other.PreviewFileUri = PreviewFile?.Uri ?? default;
            other.PreviewFileWidth = PreviewFile?.Width ?? default;
            other.PreviewFileHeight = PreviewFile?.Height ?? default;
            other.ScreenFileUri = ScreenFile?.Uri ?? default;
            other.ScreenFileWidth = ScreenFile?.Width ?? default;
            other.ScreenFileHeight = ScreenFile?.Height ?? default;
            other.FullFileUri = FullFile?.Uri ?? default;
            other.FullFileWidth = FullFile?.Width ?? default;
            other.FullFileHeight = FullFile?.Height ?? default;
            other.MediumThumbnailUri = MediumThumbnail?.Uri ?? default;
            other.MediumThumbnailWidth = MediumThumbnail?.Width ?? default;
            other.MediumThumbnailHeight = MediumThumbnail?.Height ?? default;
            other.MediumCustomThumbnailUri = MediumCustomThumbnail?.Uri ?? default;
            other.MediumCustomThumbnailWidth = MediumCustomThumbnail?.Width ?? default;
            other.MediumCustomThumbnailHeight = MediumCustomThumbnail?.Height ?? default;
            other.LargeThumbnailUri = LargeThumbnail?.Uri ?? default;
            other.LargeThumbnailWidth = LargeThumbnail?.Width ?? default;
            other.LargeThumbnailHeight = LargeThumbnail?.Height ?? default;
            other.LargeCustomThumbnailUri = LargeCustomThumbnail?.Uri ?? default;
            other.LargeCustomThumbnailWidth = LargeCustomThumbnail?.Width ?? default;
            other.LargeCustomThumbnailHeight = LargeCustomThumbnail?.Height ?? default;
            other.HugeThumbnailUri = HugeThumbnail?.Uri ?? default;
            other.HugeThumbnailWidth = HugeThumbnail?.Width ?? default;
            other.HugeThumbnailHeight = HugeThumbnail?.Height ?? default;
            other.HugeCustomThumbnailUri = HugeCustomThumbnail?.Uri ?? default;
            other.HugeCustomThumbnailWidth = HugeCustomThumbnail?.Width ?? default;
            other.HugeCustomThumbnailHeight = HugeCustomThumbnail?.Height ?? default;
        }
    }

    internal partial class SubmissionPoolRaw
    {
        [JsonProperty("submission_left_submission_id")]
        public int PreviousSubmissionId { get; set; }

        [JsonProperty("submission_left_file_name")]
        public string PreviousSubmissionFileName { get; set; }

        [JsonProperty("submission_left_thumbnail_url_medium_noncustom")]
        public Uri PreviousSubmissionMediumThumbnailUri { get; set; }

        [JsonProperty("submission_left_thumb_medium_noncustom_x")]
        public int? PreviousSubmissionMediumThumbnailWidth { get; set; }

        [JsonProperty("submission_left_thumb_medium_noncustom_y")]
        public int? PreviousSubmissionMediumThumbnailHeight { get; set; }

        [JsonProperty("submission_left_thumbnail_url_medium")]
        public Uri PreviousSubmissionMediumCustomThumbnailUri { get; set; }

        [JsonProperty("submission_left_thumb_medium_x")]
        public int? PreviousSubmissionMediumCustomThumbnailWidth { get; set; }

        [JsonProperty("submission_left_thumb_medium_y")]
        public int? PreviousSubmissionMediumCustomThumbnailHeight { get; set; }

        [JsonProperty("submission_left_thumbnail_url_large_noncustom")]
        public Uri PreviousSubmissionLargeThumbnailUri { get; set; }

        [JsonProperty("submission_left_thumb_large_noncustom_x")]
        public int? PreviousSubmissionLargeThumbnailWidth { get; set; }

        [JsonProperty("submission_left_thumb_large_noncustom_y")]
        public int? PreviousSubmissionLargeThumbnailHeight { get; set; }

        [JsonProperty("submission_left_thumbnail_url_large")]
        public Uri PreviousSubmissionLargeCustomThumbnailUri { get; set; }

        [JsonProperty("submission_left_thumb_large_x")]
        public int? PreviousSubmissionLargeCustomThumbnailWidth { get; set; }

        [JsonProperty("submission_left_thumb_large_y")]
        public int? PreviousSubmissionLargeCustomThumbnailHeight { get; set; }

        [JsonProperty("submission_left_thumbnail_url_huge_noncustom")]
        public Uri PreviousSubmissionHugeThumbnailUri { get; set; }

        [JsonProperty("submission_left_thumb_huge_noncustom_x")]
        public int? PreviousSubmissionHugeThumbnailWidth { get; set; }

        [JsonProperty("submission_left_thumb_huge_noncustom_y")]
        public int? PreviousSubmissionHugeThumbnailHeight { get; set; }

        [JsonProperty("submission_left_thumbnail_url_huge")]
        public Uri PreviousSubmissionHugeCustomThumbnailUri { get; set; }

        [JsonProperty("submission_left_thumb_huge_x")]
        public int? PreviousSubmissionHugeCustomThumbnailWidth { get; set; }

        [JsonProperty("submission_left_thumb_huge_y")]
        public int? PreviousSubmissionHugeCustomThumbnailHeight { get; set; }

        [JsonProperty("submission_right_submission_id")]
        public int NextSubmissionId { get; set; }

        [JsonProperty("submission_right_file_name")]
        public string NextSubmissionFileName { get; set; }

        [JsonProperty("submission_right_thumbnail_url_medium_noncustom")]
        public Uri NextSubmissionMediumThumbnailUri { get; set; }

        [JsonProperty("submission_right_thumb_medium_noncustom_x")]
        public int? NextSubmissionMediumThumbnailWidth { get; set; }

        [JsonProperty("submission_right_thumb_medium_noncustom_y")]
        public int? NextSubmissionMediumThumbnailHeight { get; set; }

        [JsonProperty("submission_right_thumbnail_url_medium")]
        public Uri NextSubmissionMediumCustomThumbnailUri { get; set; }

        [JsonProperty("submission_right_thumb_medium_x")]
        public int? NextSubmissionMediumCustomThumbnailWidth { get; set; }

        [JsonProperty("submission_right_thumb_medium_y")]
        public int? NextSubmissionMediumCustomThumbnailHeight { get; set; }

        [JsonProperty("submission_right_thumbnail_url_large_noncustom")]
        public Uri NextSubmissionLargeThumbnailUri { get; set; }

        [JsonProperty("submission_right_thumb_large_noncustom_x")]
        public int? NextSubmissionLargeThumbnailWidth { get; set; }

        [JsonProperty("submission_right_thumb_large_noncustom_y")]
        public int? NextSubmissionLargeThumbnailHeight { get; set; }

        [JsonProperty("submission_right_thumbnail_url_large")]
        public Uri NextSubmissionLargeCustomThumbnailUri { get; set; }

        [JsonProperty("submission_right_thumb_large_x")]
        public int? NextSubmissionLargeCustomThumbnailWidth { get; set; }

        [JsonProperty("submission_right_thumb_large_y")]
        public int? NextSubmissionLargeCustomThumbnailHeight { get; set; }

        [JsonProperty("submission_right_thumbnail_url_huge_noncustom")]
        public Uri NextSubmissionHugeThumbnailUri { get; set; }

        [JsonProperty("submission_right_thumb_huge_noncustom_x")]
        public int? NextSubmissionHugeThumbnailWidth { get; set; }

        [JsonProperty("submission_right_thumb_huge_noncustom_y")]
        public int? NextSubmissionHugeThumbnailHeight { get; set; }

        [JsonProperty("submission_right_thumbnail_url_huge")]
        public Uri NextSubmissionHugeCustomThumbnailUri { get; set; }

        [JsonProperty("submission_right_thumb_huge_x")]
        public int? NextSubmissionHugeCustomThumbnailWidth { get; set; }

        [JsonProperty("submission_right_thumb_huge_y")]
        public int? NextSubmissionHugeCustomThumbnailHeight { get; set; }

        private void CopyToNormal(SubmissionPool other)
        {
            other.PreviousSubmission = new SubmissionPoolSubmission {
                Id = PreviousSubmissionId,
                FileName = PreviousSubmissionFileName,
                MediumThumbnail = new SubmissionThumbnail {
                    Uri = PreviousSubmissionMediumThumbnailUri,
                    Width = PreviousSubmissionMediumThumbnailWidth,
                    Height = PreviousSubmissionMediumThumbnailHeight,
                },
                MediumCustomThumbnail = new SubmissionThumbnail {
                    Uri = PreviousSubmissionMediumCustomThumbnailUri,
                    Width = PreviousSubmissionMediumCustomThumbnailWidth,
                    Height = PreviousSubmissionMediumCustomThumbnailHeight,
                },
                LargeThumbnail = new SubmissionThumbnail {
                    Uri = PreviousSubmissionLargeThumbnailUri,
                    Width = PreviousSubmissionLargeThumbnailWidth,
                    Height = PreviousSubmissionLargeThumbnailHeight,
                },
                LargeCustomThumbnail = new SubmissionThumbnail {
                    Uri = PreviousSubmissionLargeCustomThumbnailUri,
                    Width = PreviousSubmissionLargeCustomThumbnailWidth,
                    Height = PreviousSubmissionLargeCustomThumbnailHeight,
                },
                HugeThumbnail = new SubmissionThumbnail {
                    Uri = PreviousSubmissionHugeThumbnailUri,
                    Width = PreviousSubmissionHugeThumbnailWidth,
                    Height = PreviousSubmissionHugeThumbnailHeight,
                },
                HugeCustomThumbnail = new SubmissionThumbnail {
                    Uri = PreviousSubmissionHugeCustomThumbnailUri,
                    Width = PreviousSubmissionHugeCustomThumbnailWidth,
                    Height = PreviousSubmissionHugeCustomThumbnailHeight,
                },
            };
            other.NextSubmission = new SubmissionPoolSubmission {
                Id = NextSubmissionId,
                FileName = NextSubmissionFileName,
                MediumThumbnail = new SubmissionThumbnail {
                    Uri = NextSubmissionMediumThumbnailUri,
                    Width = NextSubmissionMediumThumbnailWidth,
                    Height = NextSubmissionMediumThumbnailHeight,
                },
                MediumCustomThumbnail = new SubmissionThumbnail {
                    Uri = NextSubmissionMediumCustomThumbnailUri,
                    Width = NextSubmissionMediumCustomThumbnailWidth,
                    Height = NextSubmissionMediumCustomThumbnailHeight,
                },
                LargeThumbnail = new SubmissionThumbnail {
                    Uri = NextSubmissionLargeThumbnailUri,
                    Width = NextSubmissionLargeThumbnailWidth,
                    Height = NextSubmissionLargeThumbnailHeight,
                },
                LargeCustomThumbnail = new SubmissionThumbnail {
                    Uri = NextSubmissionLargeCustomThumbnailUri,
                    Width = NextSubmissionLargeCustomThumbnailWidth,
                    Height = NextSubmissionLargeCustomThumbnailHeight,
                },
                HugeThumbnail = new SubmissionThumbnail {
                    Uri = NextSubmissionHugeThumbnailUri,
                    Width = NextSubmissionHugeThumbnailWidth,
                    Height = NextSubmissionHugeThumbnailHeight,
                },
                HugeCustomThumbnail = new SubmissionThumbnail {
                    Uri = NextSubmissionHugeCustomThumbnailUri,
                    Width = NextSubmissionHugeCustomThumbnailWidth,
                    Height = NextSubmissionHugeCustomThumbnailHeight,
                },
            };
        }
    }

    public partial class SubmissionPool
    {
        private void CopyToRaw(SubmissionPoolRaw other)
        {
            other.PreviousSubmissionId = PreviousSubmission?.Id ?? default;
            other.PreviousSubmissionFileName = PreviousSubmission?.FileName ?? default;
            other.PreviousSubmissionMediumThumbnailUri = PreviousSubmission?.MediumThumbnail?.Uri ?? default;
            other.PreviousSubmissionMediumThumbnailWidth = PreviousSubmission?.MediumThumbnail?.Width ?? default;
            other.PreviousSubmissionMediumThumbnailHeight = PreviousSubmission?.MediumThumbnail?.Height ?? default;
            other.PreviousSubmissionMediumCustomThumbnailUri = PreviousSubmission?.MediumCustomThumbnail?.Uri ?? default;
            other.PreviousSubmissionMediumCustomThumbnailWidth = PreviousSubmission?.MediumCustomThumbnail?.Width ?? default;
            other.PreviousSubmissionMediumCustomThumbnailHeight = PreviousSubmission?.MediumCustomThumbnail?.Height ?? default;
            other.PreviousSubmissionLargeThumbnailUri = PreviousSubmission?.LargeThumbnail?.Uri ?? default;
            other.PreviousSubmissionLargeThumbnailWidth = PreviousSubmission?.LargeThumbnail?.Width ?? default;
            other.PreviousSubmissionLargeThumbnailHeight = PreviousSubmission?.LargeThumbnail?.Height ?? default;
            other.PreviousSubmissionLargeCustomThumbnailUri = PreviousSubmission?.LargeCustomThumbnail?.Uri ?? default;
            other.PreviousSubmissionLargeCustomThumbnailWidth = PreviousSubmission?.LargeCustomThumbnail?.Width ?? default;
            other.PreviousSubmissionLargeCustomThumbnailHeight = PreviousSubmission?.LargeCustomThumbnail?.Height ?? default;
            other.PreviousSubmissionHugeThumbnailUri = PreviousSubmission?.HugeThumbnail?.Uri ?? default;
            other.PreviousSubmissionHugeThumbnailWidth = PreviousSubmission?.HugeThumbnail?.Width ?? default;
            other.PreviousSubmissionHugeThumbnailHeight = PreviousSubmission?.HugeThumbnail?.Height ?? default;
            other.PreviousSubmissionHugeCustomThumbnailUri = PreviousSubmission?.HugeCustomThumbnail?.Uri ?? default;
            other.PreviousSubmissionHugeCustomThumbnailWidth = PreviousSubmission?.HugeCustomThumbnail?.Width ?? default;
            other.PreviousSubmissionHugeCustomThumbnailHeight = PreviousSubmission?.HugeCustomThumbnail?.Height ?? default;
            other.NextSubmissionId = NextSubmission?.Id ?? default;
            other.NextSubmissionFileName = NextSubmission?.FileName ?? default;
            other.NextSubmissionMediumThumbnailUri = NextSubmission?.MediumThumbnail?.Uri ?? default;
            other.NextSubmissionMediumThumbnailWidth = NextSubmission?.MediumThumbnail?.Width ?? default;
            other.NextSubmissionMediumThumbnailHeight = NextSubmission?.MediumThumbnail?.Height ?? default;
            other.NextSubmissionMediumCustomThumbnailUri = NextSubmission?.MediumCustomThumbnail?.Uri ?? default;
            other.NextSubmissionMediumCustomThumbnailWidth = NextSubmission?.MediumCustomThumbnail?.Width ?? default;
            other.NextSubmissionMediumCustomThumbnailHeight = NextSubmission?.MediumCustomThumbnail?.Height ?? default;
            other.NextSubmissionLargeThumbnailUri = NextSubmission?.LargeThumbnail?.Uri ?? default;
            other.NextSubmissionLargeThumbnailWidth = NextSubmission?.LargeThumbnail?.Width ?? default;
            other.NextSubmissionLargeThumbnailHeight = NextSubmission?.LargeThumbnail?.Height ?? default;
            other.NextSubmissionLargeCustomThumbnailUri = NextSubmission?.LargeCustomThumbnail?.Uri ?? default;
            other.NextSubmissionLargeCustomThumbnailWidth = NextSubmission?.LargeCustomThumbnail?.Width ?? default;
            other.NextSubmissionLargeCustomThumbnailHeight = NextSubmission?.LargeCustomThumbnail?.Height ?? default;
            other.NextSubmissionHugeThumbnailUri = NextSubmission?.HugeThumbnail?.Uri ?? default;
            other.NextSubmissionHugeThumbnailWidth = NextSubmission?.HugeThumbnail?.Width ?? default;
            other.NextSubmissionHugeThumbnailHeight = NextSubmission?.HugeThumbnail?.Height ?? default;
            other.NextSubmissionHugeCustomThumbnailUri = NextSubmission?.HugeCustomThumbnail?.Uri ?? default;
            other.NextSubmissionHugeCustomThumbnailWidth = NextSubmission?.HugeCustomThumbnail?.Width ?? default;
            other.NextSubmissionHugeCustomThumbnailHeight = NextSubmission?.HugeCustomThumbnail?.Height ?? default;
        }
    }
}
