using System;
using Queue.Model;

namespace Queue
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Queue *****");
      
      var linkedQueue = new LinkedQueue<int>();
      linkedQueue.Enqueue(1);
      linkedQueue.Enqueue(2);
      linkedQueue.Enqueue(3);
      linkedQueue.Enqueue(4);
      linkedQueue.Enqueue(5);

      Console.WriteLine(linkedQueue.Dequeue());
      Console.WriteLine(linkedQueue.Peek());
    }
  }
}