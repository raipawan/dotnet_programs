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
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public class Queue
        {
            Node front, rear;

            public Queue()
            {
                this.front = null;
                this.rear = null;
            }

            public void Enqueue(int data)
            {

                Node temp = new Node(data);

                if (rear == null)
                {
                    this.front = this.rear = temp;
                }
                this.rear.next = temp;
                this.rear = temp;
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
}
