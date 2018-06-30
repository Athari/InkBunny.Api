using System;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class BooleanTFConverter : JsonConverter<bool>
    {
        public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
        {
            writer.WriteValue(value ? "t" : "f");
        }

        public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType) {
                case JsonToken.String:
                    switch (reader.Value.ToString()) {
                        case "t":
                            return true;
                        case "f":
                            return false;
                        default:
                            throw new ArgumentException();
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}