using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignment
{
    class PowerOf2
    {
        public void getPower()
        {
            Console.WriteLine("enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 30)
            {
                Console.WriteLine("enter number less than 31 ");
            }

            if (n < 31)
            {
                int value = 2;

                for (int power = 0; power <= n; power++)
                {
                    Console.WriteLine($"{value}^{power} = {Math.Pow(value, power)}");

                }
            }

        }
    }
}
