using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    internal class SetSubmissionPageOrderRequest : BasicSubmissionPageRequest
    {
        [JsonProperty("newpos")]
        public int Order { get; set; }

        public SetSubmissionPageOrderRequest(int fileId) : base(fileId)
        { }
    }
}