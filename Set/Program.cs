using System;
using System.Collections.Generic;
using Set.Model;

namespace Set
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Set *****");
      var simpleSet1 = new SimpleSet<int>(new int[] {1, 2, 3, 4, 5});
      var simpleSet2 = new SimpleSet<int>(new int[] {4, 5, 6, 7, 8});
      var simpleSet3 = new SimpleSet<int>(new int[] {3, 4, 5}); 
    }
  }
}