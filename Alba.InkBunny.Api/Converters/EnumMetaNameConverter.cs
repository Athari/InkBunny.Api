using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Alba.InkBunny.Api.Framework;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class EnumMetaNameConverter<T> : JsonConverter<T>
        where T : Enum
    {
        private static readonly IDictionary<T, string> ValueToName = new SortedList<T, string>();
        private static readonly IDictionary<string, T> NameToValue = new SortedList<string, T>();

        static EnumMetaNameConverter()
        {
            var items = typeof(T).GetFields().Where(f => f.FieldType.IsEnum).Select(f => new {
                value = (T)Enum.ToObject(typeof(T), f.GetRawConstantValue()),
                name = ((EnumMetaAttribute)f.GetCustomAttribute(typeof(EnumMetaAttribute))).JsonName,
            });
            foreach (var item in items) {
                ValueToName.Add(item.value, item.name);
                NameToValue.Add(item.name, item.value);
            }
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            writer.WriteValue(ValueToName.TryGetValue(value, out var name) ? name : "");
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType) {
                case JsonToken.Integer:
                    return NameToValue.TryGetValue(reader.Value.ToString(), out var num) ? num : default;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}