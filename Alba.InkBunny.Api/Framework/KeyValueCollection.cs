using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Alba.InkBunny.Api.Framework
{
    internal class KeyValueCollection : List<KeyValuePair<string, string>>, IDictionary<string, string>
    {
        public KeyValueCollection()
        { }

        public KeyValueCollection(int capacity) : base(capacity)
        { }

        public KeyValueCollection(IEnumerable<KeyValuePair<string, string>> collection) : base(collection)
        { }

        public static KeyValueCollection FromJson(object value) =>
            new KeyValueCollection(JObject.FromObject(value).Properties()
                .Where(p => p.Value != null)
                .Select(p => new KeyValuePair<string, string>(p.Name, p.Value.ToString())));

        public bool ContainsKey(string key) => this.Any(i => i.Key == key);

        public void Add(string key, string value) => Add(new KeyValuePair<string, string>(key, value));

        public bool Remove(string key)
        {
            int index = FindIndex(i => i.Key == key);
            if (index == -1)
                return false;
            else {
                RemoveAt(index);
                return true;
            }
        }

        public bool TryGetValue(string key, out string value)
        {
            int index = FindIndex(i => i.Key == key);
            if (index == -1) {
                value = null;
                return false;
            }
            else {
                value = this[index].Value;
                return true;
            }
        }

        public string this[string key]
        {
            get
            {
                int index = FindIndex(i => i.Key == key);
                return index == -1 ? null : this[index].Value;
            }
            set => Add(key, value);
        }

        ICollection<string> IDictionary<string, string>.Keys => new ReadOnlyCollection<string>(this.Select(i => i.Key).ToList());
        ICollection<string> IDictionary<string, string>.Values => new ReadOnlyCollection<string>(this.Select(i => i.Value).ToList());
    }
}