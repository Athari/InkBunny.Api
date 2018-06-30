using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public sealed class SubmissionsReponse : BaseResponse
    {
        [JsonProperty("submissions")]
        public IList<Submission> Submissions { get; set; }
    }
}