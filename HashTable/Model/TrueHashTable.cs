namespace HashTable.Model
{
  public class TrueHashTable<T>
  {
    private Item<T>[] _items;

    public TrueHashTable(int size)
    {
      _items = new Item<T>[size];

      for (var i = 0; i < _items.Length; i++)
        _items[i] = new Item<T>(i);
    }

    private int GetHash(T item) => item.GetHashCode() % _items.Length;

    public void Add(T item)
    {
      var hashKey = GetHash(item);
      _items[hashKey].Nodes.Add(item);
    }

    public bool Search(T item)
    {
      var hashKey = GetHash(item);
      return _items[hashKey].Nodes.Contains(item);
    }
    
  }
}