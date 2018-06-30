using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Alba.InkBunny.Api.Converters;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public sealed class SubmissionsQuery
    {
        [JsonIgnore]
        public IList<Submission> Submissions { get; set; }

        [JsonProperty("submission_ids"), JsonConverter(typeof(IntegerListConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IEnumerable<int> SubmissionIds => Submissions.Select(s => s.Id);

        [JsonIgnore]
        public SubmissionIncludeData IncludeData { get; set; } = SubmissionIncludeData.Default;

        [JsonProperty("show_description"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludeDescription => IncludeData.Has(SubmissionIncludeData.Description);

        [JsonProperty("show_description_bbcode_parsed"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludeDescriptionHtml => IncludeData.Has(SubmissionIncludeData.DescriptionHtml);

        [JsonProperty("show_Writing"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludeWriting => IncludeData.Has(SubmissionIncludeData.Writing);

        [JsonProperty("show_Writing_bbcode_parsed"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludeWritingHtml => IncludeData.Has(SubmissionIncludeData.WritingHtml);

        [JsonProperty("show_pools"), JsonConverter(typeof(BooleanYesNoConverter))]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IncludePools => IncludeData.Has(SubmissionIncludeData.Pools);
    }
}