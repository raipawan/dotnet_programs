using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            /* StackUsingLinkedList my_stack = new StackUsingLinkedList();
             my_stack.push(70);
             my_stack.push(40);
             my_stack.push(77);
             my_stack.push(798);
             my_stack.pop();
             my_stack.display();*/

            /*  QueueUsingLinkedList my_queue = new QueueUsingLinkedList();
              my_queue.e*/

            Solution solution = new Solution();
            int[] marks = new int[5] { 0, 2, 2, 3, 4 };
            int[] arr = solution.duplicates(marks, 5);
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }






        }
    }
}
