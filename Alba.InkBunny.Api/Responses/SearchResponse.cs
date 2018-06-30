using System;
using System.Collections.Generic;
using System.ComponentModel;
using Alba.InkBunny.Api.Converters;
using Alba.InkBunny.Api.Framework;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    [PublicAPI]
    public sealed class SearchResponse : BaseResponse
    {
        [JsonProperty("results_count_all")]
        public int SubmissionCount { get; set; }

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

        [JsonProperty("submissions", ItemConverterType = typeof(RawConverter<Submission, SubmissionRaw>))]
        public IList<Submission> Submissions { get; set; }
    }

    [PublicAPI]
    public sealed class SearchParameter
    {
        [JsonProperty("param_name")]
        public string Name { get; set; }

        [JsonProperty("param_value")]
        public string Value { get; set; }
    }

    [PublicAPI]
    public sealed class Keyword
    {
        [JsonProperty("keyword_id")]
        public int Id { get; set; }

        [JsonProperty("keyword_name")]
        public string Name { get; set; }

        [JsonProperty("submissions_count")]
        public int SubmissionCount { get; set; }

        // Extended

        [JsonProperty("contributed"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsSuggested { get; set; }
    }

    [PublicAPI]
    public class SubmissionBase
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

        [JsonIgnore]
        public bool HasSales => HasDigitalSales || HasPrintSales;

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("pagecount")]
        public string PageCount { get; set; }

        [JsonProperty("rating_id")]
        public RatingLevel RatingLevel { get; set; }

        [JsonProperty("submission_type_id"), JsonConverter(typeof(EnumIntegerSingleFlagConverter<SubmisionType>))]
        public SubmisionType Type { get; set; }

        [JsonProperty("type_name")]
        public string TypeName { get; set; }

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

        [JsonProperty("files", ItemConverterType = typeof(RawConverter<SubmissionPage, SubmissionPageRaw>))]
        public IList<SubmissionPage> Pages { get; set; }

        // Extended

        [JsonProperty("favorite"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsFavorite { get; set; }

        [JsonProperty("favorites_count")]
        public int FavoriteCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentCount { get; set; }

        [JsonProperty("views")]
        public int ViewCount { get; set; }

        [JsonProperty("digital_price")]
        public decimal DigitalPrice { get; set; }

        [JsonProperty("user_icon_file_name")]
        public string UserIconFileName { get; set; }

        [JsonProperty("user_icon_url_small")]
        public Uri UserSmallIconUri { get; set; }

        [JsonProperty("user_icon_url_medium")]
        public Uri UserMediumIconUri { get; set; }

        [JsonProperty("user_icon_url_large")]
        public Uri UserLargeIconUri { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_bbcode_parsed")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("sales_description")]
        public string SaleDescription { get; set; }

        [JsonProperty("writing")]
        public string Writing { get; set; }

        [JsonProperty("writing_bbcode_parsed")]
        public string WritingHtml { get; set; }

        [JsonProperty("keywords")]
        public IList<Keyword> Keywords { get; set; }

        [JsonProperty("ratings")]
        public IList<SubmissionRating> Ratings { get; set; }

        private protected SubmissionBase()
        { }

        private protected void CopyToBase(SubmissionBase other)
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
            // Extended
            other.IsFavorite = IsFavorite;
            other.FavoriteCount = FavoriteCount;
            other.CommentCount = CommentCount;
            other.ViewCount = ViewCount;
            other.DigitalPrice = DigitalPrice;
            other.UserIconFileName = UserIconFileName;
            other.UserSmallIconUri = UserSmallIconUri;
            other.UserMediumIconUri = UserMediumIconUri;
            other.UserLargeIconUri = UserLargeIconUri;
            other.Description = Description;
            other.DescriptionHtml = DescriptionHtml;
            other.SaleDescription = SaleDescription;
            other.Writing = Writing;
            other.WritingHtml = WritingHtml;
            other.Keywords = Keywords;
            other.Ratings = Ratings;
        }
    }

    internal sealed partial class SubmissionRaw : SubmissionBase, ICopyable<Submission>
    {
        void ICopyable<Submission>.CopyTo(Submission other)
        {
            CopyToBase(other);
            CopyToNormal(other);
        }
    }

    [PublicAPI]
    public sealed partial class Submission : SubmissionBase, ICopyable<SubmissionRaw>
    {
        [JsonIgnore]
        public SubmissionPage PrimaryPage { get; set; }

        [JsonIgnore]
        public SubmissionPage LatestPage { get; set; }

        void ICopyable<SubmissionRaw>.CopyTo(SubmissionRaw other)
        {
            CopyToBase(other);
            CopyToRaw(other);
        }
    }

    [PublicAPI]
    public class SubmissionPageBase
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("mimetype")]
        public string MimeType { get; set; }

        // Extended

        [JsonProperty("file_id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("submission_id")]
        public int SubmissionId { get; set; }

        [JsonProperty("submission_file_order")]
        public int Order { get; set; }

        [JsonProperty("deleted"), JsonConverter(typeof(BooleanTFConverter))]
        public bool IsDeleted { get; set; }

        private protected SubmissionPageBase()
        { }

        private protected void CopyToBase(SubmissionPageBase other)
        {
            other.FileName = FileName;
            other.MimeType = MimeType;
            other.Id = Id;
            other.UserId = UserId;
            other.SubmissionId = SubmissionId;
            other.Order = Order;
            other.IsDeleted = IsDeleted;
        }
    }

    [PublicAPI]
    public sealed partial class SubmissionPage : SubmissionPageBase, IThumbnailHolder, ICopyable<SubmissionPageRaw>
    {
        [JsonIgnore]
        public SubmissionFile PreviewFile { get; set; }

        [JsonIgnore]
        public SubmissionFile ScreenFile { get; set; }

        [JsonIgnore]
        public SubmissionFile FullFile { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail MediumThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail MediumCustomThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail LargeThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail LargeCustomThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail HugeThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail HugeCustomThumbnail { get; set; }

        void ICopyable<SubmissionPageRaw>.CopyTo(SubmissionPageRaw other)
        {
            CopyToBase(other);
            CopyToRaw(other);
        }
    }

    internal sealed partial class SubmissionPageRaw : SubmissionPageBase, ICopyable<SubmissionPage>
    {
        void ICopyable<SubmissionPage>.CopyTo(SubmissionPage other)
        {
            CopyToBase(other);
            CopyToNormal(other);
        }
    }

    [PublicAPI]
    public sealed class SubmissionFile
    {
        [JsonIgnore]
        public Uri Uri { get; set; }

        [JsonIgnore]
        public int Width { get; set; }

        [JsonIgnore]
        public int Height { get; set; }
    }

    [PublicAPI]
    public sealed class SubmissionThumbnail
    {
        [JsonIgnore]
        public Uri Uri { get; set; }

        [JsonIgnore]
        public int? Width { get; set; }

        [JsonIgnore]
        public int? Height { get; set; }
    }

    [PublicAPI]
    public sealed class SubmissionRating
    {
        [JsonProperty("content_tag_id")]
        public int Id { get; set; }

        [JsonProperty("rating_id")]
        public int RatingId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [PublicAPI]
    public class SubmissionPoolBase
    {
        [JsonProperty("pool_id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("count")]
        public int SubmissionCount { get; set; }

        private protected SubmissionPoolBase()
        { }

        private protected void CopyToBase(SubmissionPoolBase other)
        {
            other.Id = Id;
            other.Name = Name;
            other.Description = Description;
            other.SubmissionCount = SubmissionCount;
        }
    }

    [PublicAPI]
    public sealed partial class SubmissionPool : SubmissionPoolBase, ICopyable<SubmissionPoolRaw>
    {
        [JsonIgnore]
        public SubmissionPoolSubmission PreviousSubmission { get; set; }

        [JsonIgnore]
        public SubmissionPoolSubmission NextSubmission { get; set; }

        void ICopyable<SubmissionPoolRaw>.CopyTo(SubmissionPoolRaw other)
        {
            CopyToBase(other);
            CopyToRaw(other);
        }
    }

    [PublicAPI]
    internal sealed partial class SubmissionPoolRaw : SubmissionPoolBase, ICopyable<SubmissionPool>
    {
        void ICopyable<SubmissionPool>.CopyTo(SubmissionPool other)
        {
            CopyToBase(other);
            CopyToNormal(other);
        }
    }

    [PublicAPI]
    public sealed class SubmissionPoolSubmission : IThumbnailHolder
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public string FileName { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail MediumThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail MediumCustomThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail LargeThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail LargeCustomThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail HugeThumbnail { get; set; }

        [JsonIgnore]
        public SubmissionThumbnail HugeCustomThumbnail { get; set; }
    }

    [PublicAPI]
    public sealed class SubmissionPrint
    {
        [JsonProperty("print_size_id")]
        public int SizeId { get; set; }

        [JsonProperty("name")]
        public string SizeName { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("price_owner_discount")]
        public decimal PriceOwnerDiscount { get; set; }
    }
}