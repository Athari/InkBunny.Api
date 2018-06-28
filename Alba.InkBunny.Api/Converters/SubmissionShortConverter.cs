using System;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class SubmissionShortConverter : JsonConverter<SubmissionShort>
    {
        public override void WriteJson(JsonWriter writer, SubmissionShort value, JsonSerializer serializer)
        {
            var raw = new SubmissionShortRaw();
            value.CopyTo(raw);
            serializer.Serialize(writer, raw);
        }

        public override SubmissionShort ReadJson(JsonReader reader, Type objectType, SubmissionShort existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var raw = serializer.Deserialize<SubmissionShortRaw>(reader);
            var value = new SubmissionShort();
            raw.CopyTo(value);
            return value;
        }
    }
}