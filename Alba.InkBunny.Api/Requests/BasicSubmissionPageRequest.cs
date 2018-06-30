using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal class BasicSubmissionPageRequest
    {
        [JsonProperty("file_id")]
        public int FileId { get; set; }

        public BasicSubmissionPageRequest(int fileId)
        {
            FileId = fileId;
        }
    }
}