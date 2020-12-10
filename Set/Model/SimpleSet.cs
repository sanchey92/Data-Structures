using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Set.Model
{
  public class SimpleSet<T> : IEnumerable
  {
    private List<T> _items = new List<T>();
    public int Count => _items.Count;

    public SimpleSet() { }

    public SimpleSet(T data)
    {
      _items.Add(data);
    }

    public SimpleSet(IEnumerable<T> items)
    {
      _items = items.ToList();
    }

    public void Add(T item)
    {
      // if (_items.Contains(item)) return;
      foreach (var i in _items)
        if (i.Equals(item)) return;

      _items.Add(item);
    }

    public void Remove(T item) => _items.Remove(item);

    public SimpleSet<T> Union(SimpleSet<T> set)
    {
      // return new SimpleSet<T>(_items.Union(set._items));
      var result = new SimpleSet<T>();

      foreach (var item in _items)
        result.Add(item);
      
      foreach (var item in set._items)
        result.Add(item);

      return result;
    }

    public SimpleSet<T> Intersection(SimpleSet<T> set)
    {
      // return new SimpleSet<T>(_items.Intersect(set._items));
      
      var result = new SimpleSet<T>();
      
      SimpleSet<T> big;
      SimpleSet<T> small;

      if (Count >= set.Count)
      {
        big = this;
        small = set;
      }
      else
      {
        big = set;
        small = this;
      }
      
      foreach (var i in small._items)
      {
        foreach (var j in big._items)
        {
          if (i.Equals(j))
          {
            result.Add(i);
            break;
          }
        }
      }
      return result;
    }

    public SimpleSet<T> Difference(SimpleSet<T> set)
    {
      // return new SimpleSet<T>(_items.Except(set._items));
      var result = new SimpleSet<T>(_items);
      foreach (var item in set._items)
      {
        result.Remove(item);
      }
      
      return result;
    }

    public bool Subset(SimpleSet<T> set)
    {
      // return _items.All(i => set._items.Contains(i));
      foreach (var item in _items)
      {
        var equals = false;
        foreach (var item2 in set._items)
        {
          if (item.Equals(item2))
          {
            equals = true;
            break;
          }
        }
        if (!equals) return false;
      }

      return true;
    }
    
    public IEnumerator GetEnumerator()
    {
      return _items.GetEnumerator();
    }
  }
}