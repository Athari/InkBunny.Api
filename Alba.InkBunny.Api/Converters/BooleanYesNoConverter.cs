using System;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class BooleanYesNoConverter : JsonConverter<bool>
    {
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            writer.WriteValue(value ? "t" : "f");
        }

        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType) {
                case JsonToken.String:
                    return reader.Value.ToString() == "t";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}