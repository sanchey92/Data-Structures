using System;

namespace LinkedList.Model
{
  public class Item<T>
  {
    private T _data = default(T);
    
    public T Data
    {
      get => _data;
      set
      {
        if (value != null)
          _data = value;
        else 
          throw new ArgumentNullException(nameof(value));
      }
    }

    public Item<T> Next { get; set; }

    public Item(T data)
    {
      Data = data;
    }

    public override string ToString() => Data.ToString();
  }
}