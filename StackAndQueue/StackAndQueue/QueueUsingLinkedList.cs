using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class QueueUsingLinkedList
    {

        public class Node
        {
            public int data;
            public Node next;
        }

        Node front;
        Node rear;
        public QueueUsingLinkedList()
        {
            this.front = null;
            this.rear = null;
        }




        public void Enqueue(int data)
        {

            Node temp = new Node();

            if (rear == null)
            {
                this.front = this.rear = temp;
            }
            this.rear.next = temp;
            this.rear = temp;
            Console.WriteLine("added " + data);

        }

        public void dequeue()
        {
            if (this.front == null)
                Console.WriteLine("queue is empty");

            Node temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
                this.rear = null;
        }



    }
}