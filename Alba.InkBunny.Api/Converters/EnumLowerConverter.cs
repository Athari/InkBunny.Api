using System;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class EnumLowerConverter<T> : JsonConverter<T>
        where T : Enum
    {
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            writer.WriteValue((Enum.GetName(typeof(T), value) ?? "").ToLower());
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType) {
                case JsonToken.String:
                    return (T)Enum.Parse(typeof(T), reader.Value.ToString(), true);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}