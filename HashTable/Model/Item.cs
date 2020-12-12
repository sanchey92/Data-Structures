using System.Collections.Generic;

namespace HashTable.Model
{
  public class Item<T>
  {
    public int Key { get; set; }
    public List<T> Nodes { get; set; }

    public Item(int key)
    {
      Key = key;
      Nodes = new List<T>();
    }
  }
}