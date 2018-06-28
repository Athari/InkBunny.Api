using System;
using System.Globalization;
using System.Linq;
using Alba.InkBunny.Api.Framework;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class EnumIntegerMultFlagConverter<T> : JsonConverter<T>
    {
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            if (value == null) {
                writer.WriteValue("");
            }
            else {
                int num = Convert.ToInt32(value);
                string str = Enumerable.Range(0, 32)
                    .Where(i => (num & (1 << i)) != 0)
                    .Select(i => i.ToStringInv())
                    .JoinString(",");
                writer.WriteValue(str);
            }
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType) {
                case JsonToken.String:
                    int num = reader.Value.ToString().Split(',')
                        .Where(s => s != "")
                        .Select(s => int.Parse(s, CultureInfo.InvariantCulture))
                        .Aggregate(0, (a, i) => a | (1 << i));
                    return (T)Enum.ToObject(typeof(T), num);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}