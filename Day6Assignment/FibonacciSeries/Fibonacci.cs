using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class Fibonacci
    {
        public void GetSeries()
        {
            int n1 = 0;
            int n2 = 1;


            int next;

            Console.WriteLine("enter a numner of terms you want in Fabonacci series : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                next = n1 + n2;
                Console.Write(" " + next + " ");

                n1 = n2;
                n2 = next;
            }
        }
    }
}
