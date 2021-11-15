using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    class Node
    {
        int data;
        Node next;

        Node()
        {
            this.data = 0;
            this.next = null;
        }

        Node(int data)
        {
            this.data = data;
            this.next = null;
        }
        public static Node AddNode(Node head, int data)
        {
            Node temp = head;
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return head;
            }
            if (head.next == null)
                head.next = node;
            else
            {
                while (temp.next != null)
                {

                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine(head);
            return head;
        }
        /* public static int getSum(Node head)
         {
             int sum = 0;
             if (head == null)
                 return sum;
             while (head != null)
             {
                 sum = head.data + sum;
                 head = head.next;

             }

             return sum;
         }*/





    }
}
