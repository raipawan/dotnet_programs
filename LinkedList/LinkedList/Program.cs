using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = Node.AddNode(null, 5);
            Node.AddNode(head, 7);
            Node.AddNode(head, 10);

            int sum = Node.getSum(head);
            Console.WriteLine(sum);
        }
    }
}
