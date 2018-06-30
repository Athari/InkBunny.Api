using System;
using System.Linq;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class EnumIntegerSingleFlagConverter<T> : JsonConverter<T>
        where T : Enum
    {
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            int num = Convert.ToInt32(value);
            int index = Enumerable.Range(0, 32).FirstOrDefault(i => (num & (1 << i)) != 0);
            writer.WriteValue(index);
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType) {
                case JsonToken.String:
                    return (T)Enum.ToObject(typeof(T), 1 << int.Parse(reader.Value.ToString()));
                case JsonToken.Integer:
                    return (T)Enum.ToObject(typeof(T), 1 << (int)reader.Value);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}