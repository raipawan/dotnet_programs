using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class PerfectNumber
    {
        public void GetPerfect()
        {
            Console.WriteLine("enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int finalSum = 0;
            int temp = 0;

            for (int i = 1; i <= n / 2; i++)
            {

                if (n % i == 0)
                {
                    finalSum = i + temp;
                    temp = finalSum;
                }
            }

            if (n == finalSum)
            {
                Console.WriteLine("perfect number");
            }
            else
                Console.WriteLine("Not a perfect number");


        }
    }
}
