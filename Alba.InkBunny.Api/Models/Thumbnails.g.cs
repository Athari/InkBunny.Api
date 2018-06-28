//
// Generated file. Do not edit manually.
//

using System;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal partial class SubmissionShortRaw
    {
        [JsonProperty("file_name")]
        public string PrimaryPageFileName { get; set; }

        [JsonProperty("mimetype")]
        public string PrimaryPageMimeType { get; set; }

        [JsonProperty("file_url_preview")]
        public Uri PrimaryPagePreviewThumbnailUri { get; set; }

        [JsonProperty("file_url_screen")]
        public Uri PrimaryPageScreenThumbnailUri { get; set; }

        [JsonProperty("file_url_full")]
        public Uri PrimaryPageFullThumbnailUri { get; set; }

        [JsonProperty("thumbnail_url_medium_noncustom")]
        public Uri PrimaryPageMediumThumbnailUri { get; set; }

        [JsonProperty("thumb_medium_noncustom_x")]
        public int PrimaryPageMediumThumbnailWidth { get; set; }

        [JsonProperty("thumb_medium_noncustom_y")]
        public int PrimaryPageMediumThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_medium")]
        public Uri PrimaryPageMediumThumbnailCustomUri { get; set; }

        [JsonProperty("thumb_medium_x")]
        public int PrimaryPageMediumThumbnailCustomWidth { get; set; }

        [JsonProperty("thumb_medium_y")]
        public int PrimaryPageMediumThumbnailCustomHeight { get; set; }

        [JsonProperty("thumbnail_url_large_noncustom")]
        public Uri PrimaryPageLargeThumbnailUri { get; set; }

        [JsonProperty("thumb_large_noncustom_x")]
        public int PrimaryPageLargeThumbnailWidth { get; set; }

        [JsonProperty("thumb_large_noncustom_y")]
        public int PrimaryPageLargeThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_large")]
        public Uri PrimaryPageLargeThumbnailCustomUri { get; set; }

        [JsonProperty("thumb_large_x")]
        public int PrimaryPageLargeThumbnailCustomWidth { get; set; }

        [JsonProperty("thumb_large_y")]
        public int PrimaryPageLargeThumbnailCustomHeight { get; set; }

        [JsonProperty("thumbnail_url_huge_noncustom")]
        public Uri PrimaryPageHugeThumbnailUri { get; set; }

        [JsonProperty("thumb_huge_noncustom_x")]
        public int PrimaryPageHugeThumbnailWidth { get; set; }

        [JsonProperty("thumb_huge_noncustom_y")]
        public int PrimaryPageHugeThumbnailHeight { get; set; }

        [JsonProperty("thumbnail_url_huge")]
        public Uri PrimaryPageHugeThumbnailCustomUri { get; set; }

        [JsonProperty("thumb_huge_x")]
        public int PrimaryPageHugeThumbnailCustomWidth { get; set; }

        [JsonProperty("thumb_huge_y")]
        public int PrimaryPageHugeThumbnailCustomHeight { get; set; }

        [JsonProperty("latest_file_name")]
        public string LatestPageFileName { get; set; }

        [JsonProperty("latest_mimetype")]
        public string LatestPageMimeType { get; set; }

        [JsonProperty("file_latest_url_preview")]
        public Uri LatestPagePreviewThumbnailUri { get; set; }

        [JsonProperty("file_latest_url_screen")]
        public Uri LatestPageScreenThumbnailUri { get; set; }

        [JsonProperty("file_latest_url_full")]
        public Uri LatestPageFullThumbnailUri { get; set; }

        [JsonProperty("latest_thumbnail_url_medium_noncustom")]
        public Uri LatestPageMediumThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_medium_noncustom_x")]
        public int LatestPageMediumThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_medium_noncustom_y")]
        public int LatestPageMediumThumbnailHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_medium")]
        public Uri LatestPageMediumThumbnailCustomUri { get; set; }

        [JsonProperty("latest_thumb_medium_x")]
        public int LatestPageMediumThumbnailCustomWidth { get; set; }

        [JsonProperty("latest_thumb_medium_y")]
        public int LatestPageMediumThumbnailCustomHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_large_noncustom")]
        public Uri LatestPageLargeThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_large_noncustom_x")]
        public int LatestPageLargeThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_large_noncustom_y")]
        public int LatestPageLargeThumbnailHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_large")]
        public Uri LatestPageLargeThumbnailCustomUri { get; set; }

        [JsonProperty("latest_thumb_large_x")]
        public int LatestPageLargeThumbnailCustomWidth { get; set; }

        [JsonProperty("latest_thumb_large_y")]
        public int LatestPageLargeThumbnailCustomHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_huge_noncustom")]
        public Uri LatestPageHugeThumbnailUri { get; set; }

        [JsonProperty("latest_thumb_huge_noncustom_x")]
        public int LatestPageHugeThumbnailWidth { get; set; }

        [JsonProperty("latest_thumb_huge_noncustom_y")]
        public int LatestPageHugeThumbnailHeight { get; set; }

        [JsonProperty("latest_thumbnail_url_huge")]
        public Uri LatestPageHugeThumbnailCustomUri { get; set; }

        [JsonProperty("latest_thumb_huge_x")]
        public int LatestPageHugeThumbnailCustomWidth { get; set; }

        [JsonProperty("latest_thumb_huge_y")]
        public int LatestPageHugeThumbnailCustomHeight { get; set; }

        private void CopyToNormal(SubmissionShort other)
        {
            other.PrimaryPage = new SubmissionPage {
                FileName = PrimaryPageFileName,
                MimeType = PrimaryPageMimeType,
                PreviewFile = new SubmissionFile {
                    Uri = PrimaryPagePreviewThumbnailUri,
                },
                ScreenFile = new SubmissionFile {
                    Uri = PrimaryPageScreenThumbnailUri,
                },
                FullFile = new SubmissionFile {
                    Uri = PrimaryPageFullThumbnailUri,
                },
                MediumThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageMediumThumbnailUri,
                    Width = PrimaryPageMediumThumbnailWidth,
                    Height = PrimaryPageMediumThumbnailHeight,
                    CustomUri = PrimaryPageMediumThumbnailCustomUri,
                    CustomWidth = PrimaryPageMediumThumbnailCustomWidth,
                    CustomHeight = PrimaryPageMediumThumbnailCustomHeight,
                },
                LargeThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageLargeThumbnailUri,
                    Width = PrimaryPageLargeThumbnailWidth,
                    Height = PrimaryPageLargeThumbnailHeight,
                    CustomUri = PrimaryPageLargeThumbnailCustomUri,
                    CustomWidth = PrimaryPageLargeThumbnailCustomWidth,
                    CustomHeight = PrimaryPageLargeThumbnailCustomHeight,
                },
                HugeThumbnail = new SubmissionThumbnail {
                    Uri = PrimaryPageHugeThumbnailUri,
                    Width = PrimaryPageHugeThumbnailWidth,
                    Height = PrimaryPageHugeThumbnailHeight,
                    CustomUri = PrimaryPageHugeThumbnailCustomUri,
                    CustomWidth = PrimaryPageHugeThumbnailCustomWidth,
                    CustomHeight = PrimaryPageHugeThumbnailCustomHeight,
                },
            };
            other.LatestPage = new SubmissionPage {
                FileName = LatestPageFileName,
                MimeType = LatestPageMimeType,
                PreviewFile = new SubmissionFile {
                    Uri = LatestPagePreviewThumbnailUri,
                },
                ScreenFile = new SubmissionFile {
                    Uri = LatestPageScreenThumbnailUri,
                },
                FullFile = new SubmissionFile {
                    Uri = LatestPageFullThumbnailUri,
                },
                MediumThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageMediumThumbnailUri,
                    Width = LatestPageMediumThumbnailWidth,
                    Height = LatestPageMediumThumbnailHeight,
                    CustomUri = LatestPageMediumThumbnailCustomUri,
                    CustomWidth = LatestPageMediumThumbnailCustomWidth,
                    CustomHeight = LatestPageMediumThumbnailCustomHeight,
                },
                LargeThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageLargeThumbnailUri,
                    Width = LatestPageLargeThumbnailWidth,
                    Height = LatestPageLargeThumbnailHeight,
                    CustomUri = LatestPageLargeThumbnailCustomUri,
                    CustomWidth = LatestPageLargeThumbnailCustomWidth,
                    CustomHeight = LatestPageLargeThumbnailCustomHeight,
                },
                HugeThumbnail = new SubmissionThumbnail {
                    Uri = LatestPageHugeThumbnailUri,
                    Width = LatestPageHugeThumbnailWidth,
                    Height = LatestPageHugeThumbnailHeight,
                    CustomUri = LatestPageHugeThumbnailCustomUri,
                    CustomWidth = LatestPageHugeThumbnailCustomWidth,
                    CustomHeight = LatestPageHugeThumbnailCustomHeight,
                },
            };
        }
    }

    public partial class SubmissionShort
    {
        private void CopyToRaw(SubmissionShortRaw other)
        {
            other.PrimaryPageFileName = PrimaryPage.FileName;
            other.PrimaryPageMimeType = PrimaryPage.MimeType;
            other.PrimaryPagePreviewThumbnailUri = PrimaryPage.PreviewFile.Uri;
            other.PrimaryPageScreenThumbnailUri = PrimaryPage.ScreenFile.Uri;
            other.PrimaryPageFullThumbnailUri = PrimaryPage.FullFile.Uri;
            other.PrimaryPageMediumThumbnailUri = PrimaryPage.MediumThumbnail.Uri;
            other.PrimaryPageMediumThumbnailWidth = PrimaryPage.MediumThumbnail.Width;
            other.PrimaryPageMediumThumbnailHeight = PrimaryPage.MediumThumbnail.Height;
            other.PrimaryPageMediumThumbnailCustomUri = PrimaryPage.MediumThumbnail.CustomUri;
            other.PrimaryPageMediumThumbnailCustomWidth = PrimaryPage.MediumThumbnail.CustomWidth;
            other.PrimaryPageMediumThumbnailCustomHeight = PrimaryPage.MediumThumbnail.CustomHeight;
            other.PrimaryPageLargeThumbnailUri = PrimaryPage.LargeThumbnail.Uri;
            other.PrimaryPageLargeThumbnailWidth = PrimaryPage.LargeThumbnail.Width;
            other.PrimaryPageLargeThumbnailHeight = PrimaryPage.LargeThumbnail.Height;
            other.PrimaryPageLargeThumbnailCustomUri = PrimaryPage.LargeThumbnail.CustomUri;
            other.PrimaryPageLargeThumbnailCustomWidth = PrimaryPage.LargeThumbnail.CustomWidth;
            other.PrimaryPageLargeThumbnailCustomHeight = PrimaryPage.LargeThumbnail.CustomHeight;
            other.PrimaryPageHugeThumbnailUri = PrimaryPage.HugeThumbnail.Uri;
            other.PrimaryPageHugeThumbnailWidth = PrimaryPage.HugeThumbnail.Width;
            other.PrimaryPageHugeThumbnailHeight = PrimaryPage.HugeThumbnail.Height;
            other.PrimaryPageHugeThumbnailCustomUri = PrimaryPage.HugeThumbnail.CustomUri;
            other.PrimaryPageHugeThumbnailCustomWidth = PrimaryPage.HugeThumbnail.CustomWidth;
            other.PrimaryPageHugeThumbnailCustomHeight = PrimaryPage.HugeThumbnail.CustomHeight;
            other.LatestPageFileName = LatestPage.FileName;
            other.LatestPageMimeType = LatestPage.MimeType;
            other.LatestPagePreviewThumbnailUri = LatestPage.PreviewFile.Uri;
            other.LatestPageScreenThumbnailUri = LatestPage.ScreenFile.Uri;
            other.LatestPageFullThumbnailUri = LatestPage.FullFile.Uri;
            other.LatestPageMediumThumbnailUri = LatestPage.MediumThumbnail.Uri;
            other.LatestPageMediumThumbnailWidth = LatestPage.MediumThumbnail.Width;
            other.LatestPageMediumThumbnailHeight = LatestPage.MediumThumbnail.Height;
            other.LatestPageMediumThumbnailCustomUri = LatestPage.MediumThumbnail.CustomUri;
            other.LatestPageMediumThumbnailCustomWidth = LatestPage.MediumThumbnail.CustomWidth;
            other.LatestPageMediumThumbnailCustomHeight = LatestPage.MediumThumbnail.CustomHeight;
            other.LatestPageLargeThumbnailUri = LatestPage.LargeThumbnail.Uri;
            other.LatestPageLargeThumbnailWidth = LatestPage.LargeThumbnail.Width;
            other.LatestPageLargeThumbnailHeight = LatestPage.LargeThumbnail.Height;
            other.LatestPageLargeThumbnailCustomUri = LatestPage.LargeThumbnail.CustomUri;
            other.LatestPageLargeThumbnailCustomWidth = LatestPage.LargeThumbnail.CustomWidth;
            other.LatestPageLargeThumbnailCustomHeight = LatestPage.LargeThumbnail.CustomHeight;
            other.LatestPageHugeThumbnailUri = LatestPage.HugeThumbnail.Uri;
            other.LatestPageHugeThumbnailWidth = LatestPage.HugeThumbnail.Width;
            other.LatestPageHugeThumbnailHeight = LatestPage.HugeThumbnail.Height;
            other.LatestPageHugeThumbnailCustomUri = LatestPage.HugeThumbnail.CustomUri;
            other.LatestPageHugeThumbnailCustomWidth = LatestPage.HugeThumbnail.CustomWidth;
            other.LatestPageHugeThumbnailCustomHeight = LatestPage.HugeThumbnail.CustomHeight;
        }
    }
}
