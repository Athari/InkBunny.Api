using System;
using Newtonsoft.Json;
using System.Reflection;

namespace Alba.InkBunny.Api.Converters
{
    internal abstract class JsonConverter<T> : JsonConverter
    {
        public sealed override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value != null ? value is T : IsNullable(typeof(T))))
                throw new JsonSerializationException($"Converter cannot write specified value to JSON. {typeof(T)} is required.");
            WriteJson(writer, (T)value, serializer);
        }

        public abstract void WriteJson(JsonWriter writer, T value, JsonSerializer serializer);

        public sealed override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool existingIsNull = existingValue == null;
            if (!(existingIsNull || existingValue is T))
                throw new JsonSerializationException($"Converter cannot read JSON with the specified existing value. {typeof(T)} is required.");
            return ReadJson(reader, objectType, existingIsNull ? default : (T)existingValue, !existingIsNull, serializer);
        }

        public abstract T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer);

        public sealed override bool CanConvert(Type objectType) => typeof(T).IsAssignableFrom(objectType);

        private static bool IsNullable(Type t) =>
            t.GetTypeInfo().IsValueType && t.GetTypeInfo().IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
    }
}