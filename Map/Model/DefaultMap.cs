using System;
using System.Collections;

namespace Map.Model
{
    public class DefaultMap<TKey, TValue> : IEnumerable
    {
        private int _size;
        private Item<TKey, TValue>[] _items;

        public DefaultMap(int size)
        {
            _size = size;
            _items = new Item<TKey, TValue>[_size];
        }

        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);

            if (_items[hash] == null)
            {
                _items[hash] = item;
            }
            else
            {
                var placed = false;

                for (var i = hash; i < _size; i++)
                {
                    if (_items[i].Key.Equals(item.Key)) return;

                    if (_items[i] != null) continue;
                    _items[i] = item;
                    placed = true;
                    break;
                }

                if (placed) return;
                
                for (var i = 0; i < hash; i++)
                {
                    if (_items[i].Key.Equals(item.Key)) return;
                    
                    if (_items[i] != null) continue;
                    _items[i] = item;
                    placed = true;
                    break;
                }

                if (!placed)
                {
                    throw new Exception("Dictionary is full");
                }
            }
        }

        public void Remove(TKey key) 
        {
            var hash = GetHash(key);

            if (_items[hash].Key.Equals(key))
            {
                _items[hash] = null;
            }
            else
            {
                var placed = false;
                for (var i = hash; i < _size; i++)
                {
                    if (_items[i].Key.Equals(key))
                    {
                        _items[hash] = null;
                        placed = true;
                        return;
                    }
                    
                    if(_items[i] == null) return;
                }
                
                if (placed) return;

                for (var i = 0; i < hash; i++)
                {
                    if (_items[i].Key.Equals(key))
                    {
                        _items[hash] = null;
                        return;
                    }
                    if (_items[i] == null) return;
                }
            }
        }

        public TValue Search(TKey key)
        {
            var hash = GetHash(key);

            if (_items[hash] == null) return default(TValue);

            if (_items[hash].Key.Equals(key))
            {
                return _items[hash].Value;
            }
            else
            {
                var placed = false;

                for (var i = hash; i < _size; i++)
                {
                    if (_items[i].Key.Equals(key))
                    {
                        placed = true;
                        return _items[hash].Value;
                    }

                    if (_items[i] == null) return default(TValue);
                }

                if (placed) return default(TValue);
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (_items[i].Key.Equals(key))
                        {
                            return _items[hash].Value;
                        }
                        
                        if (_items[i] == null) return default(TValue);
                    }
                }
            }

            return default(TValue);
        }

        private int GetHash(TKey key) => key.GetHashCode() % _size;
        
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}