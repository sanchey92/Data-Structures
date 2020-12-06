using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Model
{
  public class SimpleStack<T> : ICloneable
  {
    private List<T> _items = new List<T>();
    public int Count => _items.Count;
    public bool IsEmpty => _items.Count == 0;

    public void Push(T item)
    {
      _items.Add(item);
    }
    
    public T Pop()
    {
      if (!IsEmpty)
      {
        var item = _items.LastOrDefault();
        _items.Remove(item);
        return item;
      }
      else
      {
        throw new NullReferenceException("Error!");
      }
    }

    public T Peek()
    {
      if (!IsEmpty)
      {
        return _items.LastOrDefault();
      }
      else
      {
        throw new NullReferenceException("Error");
      }
    }

    public override string ToString() => $"Stack with {Count} elements";
   
    public object Clone()
    {
      var newStack = new SimpleStack<T>();
      newStack._items = new List<T>(_items);
      return newStack;
    }
  }
}