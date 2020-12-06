using System;

namespace Stack.Model
{
  public class ArrayStack<T>
  {
    private T[] _items;
    private int _current = -1;
    private readonly int _initialSize = 5;
    public int MaxCount => _items.Length;
    public int Count => _current + 1;

    public ArrayStack(int size)
    {
      _items = new T[size];
      _initialSize = size;
    }

    public ArrayStack(T data, int size) : this(size)
    {
      _items[0] = data;
      _current = 1;
    }

    public void Push(T data)
    {
      if (_current < _initialSize - 1)
      {
        _current++;
        _items[_current] = data;
      }
      else
      {
        throw new StackOverflowException("Error!");
      }
    }

    public T Pop()
    {
      if (_current >= 0)
      {
        var item = _items[_current];
        _current--;
        return item;
      }
      else
      {
        throw new StackOverflowException("Error");
      }
    }

    public T Peek()
    {
      if (_current > 0)
      {
        return _items[_current];
      }
      else
      {
        throw new StackOverflowException("Error!");
      }
    }
  }
}