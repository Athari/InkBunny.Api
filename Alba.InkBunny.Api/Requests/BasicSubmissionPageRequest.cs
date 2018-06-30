using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Requests
{
    internal sealed class BasicSubmissionPageRequest
    {
        [JsonProperty("file_id")]
        public int FileId { get; set; }

        public BasicSubmissionPageRequest(int fileId)
        {
            FileId = fileId;
        }
    }
}