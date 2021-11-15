using System;

namespace LinkedList2
{
    class Program
    {
        public class Node
        {

            public int data;

            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }

        public class LinkListOperation
        {

            public Node head;

            public void AddNode(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {

                    head = node;
                }
                else
                {

                    Node temp = head;

                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }

                    temp.next = node;
                }
            }

            public void PrintList()
            {
                if (head == null)
                {
                    Console.WriteLine("List is empty");

                }
                else
                {
                    Node temp = head;
                    while (temp != null)
                    {
                        Console.WriteLine(temp.data);
                        temp = temp.next;
                    }
                }
            }


            public void Remove(int data)
            {
                if (head == null)
                {
                    Console.WriteLine("List is empty");

                }
                else
                {
                    Node temp = head;
                    Node previous = null;

                    while (!temp.data.Equals(data))
                    {
                        previous = temp;
                        temp = temp.next;
                    }
                    Console.WriteLine("Removed:" + data);
                    previous.next = temp.next;
                }
            }


            public void InsertFirst(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node temp = head;
                    head = node;
                    head.next = temp;
                }
            }

            public void DeleteFirst()
            {
                if (head == null)
                    Console.WriteLine("list is empty");
                else
                {
                    head = head.next;
                    Console.WriteLine("deleted head");
                }



            }


            public void InsertAfter(int givenNode, int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node found = head;

                    while (!found.data.Equals(givenNode))
                    {
                        found = found.next;
                    }
                    Node tempNode = found.next;
                    found.next = node;
                    found.next.next = tempNode;
                }
            }



            public void DeleteLast()
            {
                if (head == null)
                    Console.WriteLine("list is empty");
                if (head.next == null)
                {
                    head = null;
                    Console.WriteLine("removed last node ");
                }
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

                temp.next = null;

            }

            static void Main(string[] args)
            {
                LinkListOperation linkList = new LinkListOperation();
                linkList.AddNode(56);
                linkList.AddNode(30);
                linkList.AddNode(70);

                linkList.DeleteLast();
                linkList.PrintList();

            }
        }
    }
}
