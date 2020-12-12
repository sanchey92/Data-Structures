using System;
using HashTable.Model;

namespace HashTable
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Hash Table *****");
      var hashTable = new TrueHashTable<Person>(100);
      var person = new Person() {Name = "Sasha", Age = 29, Gender = 1};
      
      hashTable.Add(person);
      hashTable.Add(new Person() {Name = "Anna", Age = 32, Gender = 2});

      Console.WriteLine(hashTable.Search(person));
      
    }
  }
}