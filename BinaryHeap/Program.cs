using System;

namespace BinaryHeap
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Binary Heap *****");
            var heap = new BinaryHeap();
            
            heap.Add(20);
            heap.Add(11);
            heap.Add(17);
            heap.Add(7);
            heap.Add(4);
            heap.Add(13);
            heap.Add(15);
            heap.Add(14);
        }
    }
}