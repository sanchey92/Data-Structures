using System;
using System.Collections.Generic;

namespace BinarySearchTree.Model
{
    public class Tree<T> where T : IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }
        public int Count { get; set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        public List<T> Preorder()
        {
            return Root == null ? new List<T>() : Preorder(Root);
        }

        public List<T> Postorder()
        {
            return Root == null ? new List<T>() : Postorder(Root);
        }

        public List<T> Inorder()
        {
            return Root == null ? new List<T>() : Inorder(Root);
        }

        private static List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();

            if (node == null) return list;

            list.Add(node.Data);
            if (node.Left != null) list.AddRange(Preorder(node.Left));
            if (node.Right != null) list.AddRange(Preorder(node.Right));

            return list;
        }

        private static List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();

            if (node == null) return list;
            
            if (node.Left != null) list.AddRange(Postorder(node.Left));
            if (node.Right != null) list.AddRange(Postorder(node.Right));
            list.Add(node.Data);

            return list;
        }

        private static List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();

            if (node == null) return list;
            
            if (node.Left != null) list.AddRange(Inorder(node.Left));
            list.Add(node.Data);
            if (node.Right != null) list.AddRange(Inorder(node.Right));

            return list;
        }
    }
}