using System;
using DuplexLinkedList.Model;

namespace DuplexLinkedList
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("*** Duplex Linked list ***");
      
      var duplex = new DuplexLinkedList<int>();
      duplex.Add(1);
      duplex.Add(2);
      duplex.Add(3);
      duplex.Add(4);
      duplex.Add(5);
      

      foreach (var item in duplex)
      {
        Console.WriteLine(item);
      }
    }
  }
}