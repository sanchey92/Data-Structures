using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Map.Model
{
    public class SimpleMap<TKey, TValue> : IEnumerable
    {
        private List<Item<TKey, TValue>> _items = new List<Item<TKey, TValue>>();
        private List<TKey> _keys = new List<TKey>();

        public int Count => _items.Count;

        public SimpleMap() { }

        public void Add(Item<TKey, TValue> item)
        {
            if (_keys.Contains(item.Key)) return;
            _keys.Add(item.Key);
            _items.Add(item);
        }

        public TValue Search(TKey key)
        {
            return _keys.Contains(key)
                ? _items.Single(i => i.Key.Equals(key)).Value
                : default(TValue);
        }

        public void Remove(TKey key)
        {
            if (!_keys.Contains(key)) return;
            _keys.Remove(key);
            _items.Remove(_items.Single(i => i.Key.Equals(key)));
        }

        public IEnumerator GetEnumerator() => _items.GetEnumerator();
    }
}