using System;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class RatingJsonConverter : JsonConverter<Rating>
    {
        public override void WriteJson(JsonWriter writer, Rating value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToStringMask());
        }

        public override Rating ReadJson(JsonReader reader, Type objectType, Rating existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType) {
                case JsonToken.String:
                case JsonToken.Integer:
                    return RatingExts.Parse(reader.Value.ToString());
                default:
                    throw new NotSupportedException();
            }
        }
    }
}