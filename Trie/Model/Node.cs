using System.Collections.Generic;

namespace Trie.Model
{
    public class Node<T>
    {
        public char Symbol { get; set; }
        public T Data { get; set; }
        public bool IsWord { get; set; }
        public Dictionary<char, Node<T>> SubNodes { get; set; }

        public Node(char symbol, T data)
        {
            Symbol = symbol;
            Data = data;
            SubNodes = new Dictionary<char, Node<T>>();
        }

        public Node<T> TryFind(char symbol)
        {
            return SubNodes.TryGetValue(symbol, out var value) ? value : null;
        }

        public override string ToString() => Data.ToString();

        public override bool Equals(object obj)
        {
            if (obj is Node<T> item)
                return Data.Equals(item);
            else
                return false;
        }
    }
}