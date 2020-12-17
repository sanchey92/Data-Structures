using System;
using Map.Model;

namespace Map
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Map *****");

            var simpleMap = new DefaultMap<int, string>(100);
            
            simpleMap.Add(new Item<int, string>(1, "Homer"));
            simpleMap.Add(new Item<int, string>(2, "Marge"));
            simpleMap.Add(new Item<int, string>(3, "Bard"));
            simpleMap.Add(new Item<int, string>(3, "Bard"));
            simpleMap.Add(new Item<int, string>(4, "Liza"));

            foreach (var item in simpleMap)
            {
                Console.WriteLine(item);
            }
        }
    }
}