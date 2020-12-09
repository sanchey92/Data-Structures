using System.Linq;

namespace Queue.Model
{
  public class ArrayQueue<T>
  {
    private T[] _items;

    private T Head => _items[Count > 0 ? Count - 1 : 0];
    private T Tail => _items[0];
    private int MaxCount => _items.Length;
    public int Count { get; private set; }

    public ArrayQueue(int size)
    {
      _items = new T[size];
      Count = 0;
    }

    public ArrayQueue(int size, T data)
    {
      _items = new T[size];
      _items[0] = data;
      Count = 1;
    }

    public void Enqueue(T data)
    {
      if (Count >= MaxCount) return;
      // var result = new T[MaxCount];
      // result[0] = data;
      // for (var i = 0; i < Count; i++)
      // {
      //   result[i + 1] = _items[i];
      // }
      //
      // _items = result;
      // Count++;

      var result = (new T[] {data}).Concat(_items);
      _items = result.ToArray();
      Count++;
    }

    public T Dequeue()
    {
      var item = Head;
      Count--;
      return item;
    }

    public T Peek() => Head;
  }
}