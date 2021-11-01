using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class PrimeNumber
    {
        public void GetPrime()
        {
            Console.WriteLine("enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a >= 2)
            {
                Console.WriteLine("not a prime number");
            }
            else
                Console.WriteLine("prime number");


        }
    }
}
