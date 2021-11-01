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
                while (head.next != null)
                {
                    head = head.next;
                }
                head.next = node;
            }
            return head;
        }
        public static int getSum(Node head)
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
        }

        public int GetArraySum(int[] arr)
        {
            int sum = 0;
            int size = arr.Length;
            while (size > 0)
            {
                sum = arr[size] + sum;
                size--;
            }
            return sum;
        }



    }
}
