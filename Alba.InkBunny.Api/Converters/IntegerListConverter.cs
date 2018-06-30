using System;
using System.Collections.Generic;
using System.Linq;
using Alba.InkBunny.Api.Framework;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class IntegerListConverter : JsonConverter<IEnumerable<int>>
    {
        public override void WriteJson(JsonWriter writer, IEnumerable<int> value, JsonSerializer serializer)
        {
            writer.WriteValue(value.JoinString(","));
        }

        public override IEnumerable<int> ReadJson(JsonReader reader, Type objectType, IEnumerable<int> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType) {
                case JsonToken.String:
                    return reader.Value.ToString().Split(',').Where(s => s != "").Select(int.Parse).ToList();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}