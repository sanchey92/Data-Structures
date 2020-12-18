using System;
using BinarySearchTree.Model;

namespace BinarySearchTree
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Binaty Search Tree *****");

            var tree = new Tree<int>();
            
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);

            foreach (var item in tree.Inorder())
            {
                Console.Write(item + ", ");
            }
        }
    }
}