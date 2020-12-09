namespace Queue.Model
{
  public class LinkedQueue<T>
  {
    private Item<T> _head;
    private Item<T> _tail;
    public int Count { get; private set; }

    public LinkedQueue() { }

    public LinkedQueue(T data)
    {
      SetHeadItem(data);
    }

    public void Enqueue(T data)
    {
      if (Count == 0)
      {
        SetHeadItem(data);
        return;
      }

      var item = new Item<T>(data);
      item.Next = _tail;
      _tail = item;
      Count++;
    }

    public T Dequeue()
    {
      var data = _head.Data;

      var current = _tail.Next;
      var previous = _tail;
      
      while (current != null && current.Next != null)
      {
        previous = current;
        current = current.Next;
      }

      _head = previous;
      _head.Next = null;
      Count--;
      return data;
    }

    public T Peek() => _head.Data;

    private void SetHeadItem(T data)
    {
      var item = new Item<T>(data);
      _head = item;
      _tail = item;
      Count = 1;
    }
  }
}