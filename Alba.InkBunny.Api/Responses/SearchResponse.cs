using System;
using System.Collections.Generic;
using System.ComponentModel;
using Alba.InkBunny.Api.Converters;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public class SearchResponse : BaseResponse
    {
        //[JsonProperty("user_location")]
        //public string UserLocation { get; set; }

        [JsonProperty("results_count_all")]
        public int TotalCount { get; set; }

        [JsonProperty("pages_count")]
        public int PageCount { get; set; }

        [JsonProperty("page")]
        public int PageIndex { get; set; }

        [JsonProperty("rid"), EditorBrowsable(EditorBrowsableState.Never)]
        public string RequestId { get; set; }

        [JsonProperty("rid_ttl"), EditorBrowsable(EditorBrowsableState.Advanced)]
        public string RequestIdTimeToLive { get; set; }

        [JsonProperty("search_params")]
        public IList<SearchParameter> SearchParameters { get; set; }

        [JsonProperty("keyword_list")]
        public IList<Keyword> Keywords { get; set; }

        [JsonProperty("submissions")]
        public IList<SubmissionShort> Submissions { get; set; }
    }

    public class SearchParameter
    {
        [JsonProperty("param_name")]
        public string Name { get; set; }

        [JsonProperty("param_value")]
        public string Value { get; set; }
    }

    public class Keyword
    {
        [JsonProperty("keyword_id")]
        public int Id { get; set; }

        [JsonProperty("keyword_name")]
        public string Name { get; set; }

        [JsonProperty("submissions_count")]
        public int SubmissionCount { get; set; }
    }

    public class SubmissionShortBase
    {
        [JsonProperty("submission_id")]
        public int Id { get; set; }

        [JsonProperty("deleted"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsDeleted { get; set; }

        [JsonProperty("friends_only"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsFriendsOnly { get; set; }

        [JsonProperty("guest_block"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsGuestHidden { get; set; }

        [JsonProperty("hidden"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsHidden { get; set; }

        [JsonProperty("public"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsPublic { get; set; }

        [JsonProperty("scraps"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsScraps { get; set; }

        [JsonProperty("updated"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsUpdated { get; set; }

        [JsonProperty("digitalsales"), JsonConverter(typeof(BooleanTFConverter))]
        public bool HasDigitalSales { get; set; }

        [JsonProperty("printsales"), JsonConverter(typeof(BooleanTFConverter))]
        public bool HasPrintSales { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("pagecount")]
        public string PageCount { get; set; }

        [JsonProperty("rating_id")]
        public RatingLevel RatingLevel { get; set; }

        [JsonProperty("submission_type_id"), JsonConverter(typeof(EnumIntegerSingleFlagConverter<SubmisionType>))]
        public SubmisionType Type { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("create_datetime")]
        public DateTimeOffset CreateTime { get; set; }

        [JsonProperty("last_file_update_datetime")]
        public DateTimeOffset UpdateTime { get; set; }

        [JsonProperty("unread_datetime")]
        public DateTimeOffset UnreadTime { get; set; }

        [JsonProperty("stars")]
        public int StarCount { get; set; }

        private protected void CopyToBase(SubmissionShortBase other)
        {
            other.Id = Id;
            other.IsDeleted = IsDeleted;
            other.IsFriendsOnly = IsFriendsOnly;
            other.IsGuestHidden = IsGuestHidden;
            other.IsHidden = IsHidden;
            other.IsPublic = IsPublic;
            other.IsScraps = IsScraps;
            other.IsUpdated = IsUpdated;
            other.HasDigitalSales = HasDigitalSales;
            other.HasPrintSales = HasPrintSales;
            other.Title = Title;
            other.PageCount = PageCount;
            other.RatingLevel = RatingLevel;
            other.Type = Type;
            other.UserId = UserId;
            other.UserName = UserName;
            other.CreateTime = CreateTime;
            other.UpdateTime = UpdateTime;
            other.UnreadTime = UnreadTime;
            other.StarCount = StarCount;
        }
    }

    internal partial class SubmissionShortRaw : SubmissionShortBase
    {
        internal void CopyTo(SubmissionShort other)
        {
            CopyToBase(other);
            CopyToNormal(other);
        }
    }

    public partial class SubmissionShort : SubmissionShortBase
    {
        public SubmissionPage PrimaryPage { get; set; }
        public SubmissionPage LatestPage { get; set; }

        internal void CopyTo(SubmissionShortRaw other)
        {
            CopyToBase(other);
            CopyToRaw(other);
        }
    }

    public class SubmissionPage
    {
        public SubmissionFile PreviewFile { get; set; }
        public SubmissionFile ScreenFile { get; set; }
        public SubmissionFile FullFile { get; set; }
        public SubmissionThumbnail MediumThumbnail { get; set; }
        public SubmissionThumbnail LargeThumbnail { get; set; }
        public SubmissionThumbnail HugeThumbnail { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
    }

    public class SubmissionFile
    {
        public Uri Uri { get; set; }
    }

    public class SubmissionThumbnail
    {
        public Uri Uri { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Uri CustomUri { get; set; }
        public int CustomWidth { get; set; }
        public int CustomHeight { get; set; }
    }
}