using System;

namespace Stack.Model
{
  public class LinkedStack<T>
  {
    public Item<T> Head { get; set; }
    public int Count { get; set; }

    public bool IsEmpty => Count == 0;

    public LinkedStack()
    {
      Head = null;
      Count = 0;
    }

    public LinkedStack(T data)
    {
      Head = new Item<T>(data);
      Count = 1;
    }

    public void Push(T data)
    {
      var item = new Item<T>(data);
      item.Previous = Head;
      Head = item;
      Count++;
    }

    public T Pop()
    {
      if (!IsEmpty)
      {
        var item = Head;
        Head = Head.Previous;
        Count--;
        return item.Data;
      }
      else
      {
        throw new NullReferenceException("Error");
      }
    }
    
    public T Peek()
    {
      if (!IsEmpty)
        return Head.Data;
      else
        throw new NullReferenceException("Error!");
    }
  }
}