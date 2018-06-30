using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Requests
{
    internal sealed class BasicSubmissionRequest
    {
        [JsonProperty("submission_id")]
        public int SubmissionId { get; set; }

        public BasicSubmissionRequest(int submissionId)
        {
            SubmissionId = submissionId;
        }
    }
}