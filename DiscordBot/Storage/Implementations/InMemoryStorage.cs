using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBot.Storage.Implementations
{
    class InMemoryStorage : IDataStorage
    {
        public InMemoryStorage()
        {
            Console.WriteLine("Constructor inmemorystorage happened");
        }

        private Dictionary<string, object> _dictionary = new Dictionary<string, object>();

        public T GetObject<T>(string key)
        {
            if (!_dictionary.ContainsKey(key))
                throw new ArgumentException($"The provided '{key}'was not found");

            return (T)_dictionary[key];
        }

        public void StoreObject(object obj, string key)
        {
            if (_dictionary.ContainsKey(key)) return;
            _dictionary.Add(key, obj);
        }
    }
}
