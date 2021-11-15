using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class StackUsingLinkedList
    {
        private class Node
        {

            public int data;
            public Node next;
        }

        Node top;


        public StackUsingLinkedList()
        {
            this.top = null;
        }
        public void push(int x)
        {
            Node temp = new Node();
            temp.data = x;
            temp.next = top;
            top = temp;
        }

        public void display()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {

                    Console.Write(temp.data + "\n");
                    temp = temp.next;
                }
            }
        }

        public bool isEmpty()
        {
            return top == null;
        }
        public void peek()
        {
            if (!isEmpty())
            {
                Console.WriteLine("top is" + top.data);
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public void pop()
        {
            Node temp = new Node();
            if (temp == null)
            {
                Console.WriteLine("stack is overflow");
            }
            temp = top;
            top = top.next;
            temp.next = null;
            Console.WriteLine("removed top ");
        }


    }
}

