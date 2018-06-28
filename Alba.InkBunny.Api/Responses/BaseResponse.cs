using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api
{
    public class BaseResponse
    {
        [JsonProperty("sid"), EditorBrowsable(EditorBrowsableState.Never)]
        public string SessionId { get; set; }

        [JsonProperty("error_code"), EditorBrowsable(EditorBrowsableState.Never)]
        public int? ErrorCode { get; set; }

        [JsonProperty("error_message"), EditorBrowsable(EditorBrowsableState.Never)]
        public string ErrorMessage { get; set; }

        [JsonIgnore]
        public bool IsSuccess => ErrorCode == null && ErrorMessage == null;

        [JsonIgnore]
        public Exception Error => IsSuccess ? null : new InkBunnyException(ErrorMessage ?? "", ErrorCode ?? -1);

        internal void EnsureSuccess()
        {
            if (!IsSuccess)
                throw Error;
        }
    }
}