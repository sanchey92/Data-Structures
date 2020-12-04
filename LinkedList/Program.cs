using System;
using LinkedList.Model;

namespace LinkedList
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Linked List *****");
      
      var linkedList = new LinkedList<int>();
      
      linkedList.Add(1);
      linkedList.Add(2);
      linkedList.Add(3);
      linkedList.Add(4);
      linkedList.Add(5);

      foreach (var item in linkedList)
      {
        Console.WriteLine(item.ToString());
      }

      Console.WriteLine(linkedList.ToString());
      
    }
  }
}