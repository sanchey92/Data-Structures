using System;
using Trie.Model;

namespace Trie
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Trie*****");
            var trie = new DefaultTrie<int>();
            trie.Add("привет", 50);
            trie.Add("мир", 100);
            trie.Add("приз", 200);
            Console.WriteLine(trie);
        }
    }
}