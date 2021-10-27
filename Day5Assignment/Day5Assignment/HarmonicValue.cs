using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignment
{
    class HarmonicValue
    {
        public void getAnswer()
        {
            Console.WriteLine("enter the Value of N : ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < N + 1; i++)
            {
                Console.WriteLine("1/{0} + ", i);

            }
        }
    }
}

