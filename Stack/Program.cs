using System;
using Stack.Model;

namespace Stack
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Stack collections *****");
     
      var arrayStack = new ArrayStack<int>(5);
      
      arrayStack.Push(10);
      arrayStack.Push(20);
      arrayStack.Push(30);
      arrayStack.Push(40);
      arrayStack.Push(50);

      Console.WriteLine(arrayStack.Peek());
      Console.WriteLine(arrayStack.Pop());
      Console.WriteLine(arrayStack.Pop());
      Console.WriteLine(arrayStack.Peek());
    }
  }
}