using System.ComponentModel;
using Alba.InkBunny.Api.Converters;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public sealed class SearchRequest
    {
        [JsonProperty("rid")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string RequestId { get; set; }

        [JsonProperty("submissions_per_page")]
        public int PageSize { get; set; } = 30;

        [JsonIgnore]
        public SearchIncludeData IncludeData { get; set; } = SearchIncludeData.Default;

        [JsonProperty("keywords_list"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludeKeywords => IncludeData.Has(SearchIncludeData.Keywords);

        [JsonProperty("submission_ids_only"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludeSubmissionIdsOnly => IncludeData.Has(SearchIncludeData.SubmissionIds) && !IncludeData.Has(SearchIncludeData.Submissions);

        [JsonProperty("no_submissions"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludeNoSubmissions => IncludeData.Has(SearchIncludeData.SubmissionIds) && !IncludeData.Has(SearchIncludeData.Submissions);

        [JsonProperty("field_join_type"), JsonConverter(typeof(EnumLowerConverter<SearchJoin>))]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public SearchJoin FieldJoin { get; set; } = SearchJoin.Or;

        [JsonProperty("string_join_type"), JsonConverter(typeof(EnumLowerConverter<SearchJoin>))]
        public SearchJoin StringJoin { get; set; } = SearchJoin.And;

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("favs_user_id")]
        public int? FavoritesOfUserId { get; set; }

        [JsonProperty("keyword_id")]
        public int? KeywordId { get; set; }

        [JsonProperty("pool_id")]
        public int? PoolId { get; set; }

        [JsonProperty("orderby"), JsonConverter(typeof(EnumMetaNameConverter<SearchOrderBy>))]
        public SearchOrderBy OrderBy { get; set; }

        [JsonProperty("random"), JsonConverter(typeof(BooleanYesNoConverter))]
        public bool OrderRandom { get; set; }

        [JsonProperty("scraps"), JsonConverter(typeof(EnumMetaNameConverter<SubmisionType>))]
        public SearchGallery Gallery { get; set; } = SearchGallery.Both;

        [JsonProperty("type"), JsonConverter(typeof(EnumIntegerMultFlagConverter<SubmisionType?>))]
        public SubmisionType? SubmisionType { get; set; }

        [JsonProperty("sales")]
        public SearchSaleType? SaleTypes { get; set; }

        [JsonProperty("count_limit")]
        public int CountLimit { get; set; } = 50_000;

        [JsonProperty("dayslimit")]
        public int? LastDaysLimit { get; set; }

        [JsonProperty("unread_submissions")]
        public bool UnreadSubmissions { get; set; }

        [JsonIgnore]
        public SearchTextField TextFields { get; set; } = SearchTextField.Default;

        [JsonProperty("keywords"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool TextFieldKeywords => TextFields.Has(SearchTextField.Keywords);

        [JsonProperty("title"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool TextFieldTitle => TextFields.Has(SearchTextField.Title);

        [JsonProperty("description"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool TextFieldDescription => TextFields.Has(SearchTextField.Description);

        [JsonProperty("md5"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool TextFieldMD5 => TextFields.Has(SearchTextField.MD5);
    }
}