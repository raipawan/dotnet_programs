using System;

namespace Day14Assignment
{
    class Program
    {
        class Node
        {
            int data;
            Node next;
            Node head = null;
            Node(int data)
            {
                this.data = data;
                this.next = null;

            }

            public void AddFirst(int data)
            {

                Node node = new Node(data);
                node.next = head;
                head = node;
            }
            public void PrintList()
            {
                Node list = head;
                while (list != null)
                {
                    Console.WriteLine(list.next);
                }
            }

            static void Main(string[] args)
            {
                Node node = new Node(56);
                node.AddFirst(70);
                node.PrintList();

            }
        }
    }
}
