using System;

namespace NodeChains
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node() { Value = 3 };
            Node middle = new Node() { Value = 5 };
            first.Next = middle;
            Node last = new Node() { Value = 7 };
            middle.Next = last;
            PrintList(first);

        }

        private static void PrintList(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
