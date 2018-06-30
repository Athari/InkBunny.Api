using System;
using Alba.InkBunny.Api.Framework;
using Newtonsoft.Json;

namespace Alba.InkBunny.Api.Converters
{
    internal class RawConverter<T, TRaw> : JsonConverter<T>
        where T : ICopyable<TRaw>, new()
        where TRaw : ICopyable<T>, new()
    {
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            var raw = new TRaw();
            value.CopyTo(raw);
            serializer.Serialize(writer, raw);
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var raw = serializer.Deserialize<TRaw>(reader);
            var value = new T();
            raw.CopyTo(value);
            return value;
        }
    }
}