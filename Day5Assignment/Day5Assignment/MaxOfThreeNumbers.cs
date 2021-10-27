using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignment
{
    class MaxOfThreeNumbers
    {
        public void getMax()
        {

            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("First number " + num1 + " is the largest\n");
                }
                else if (num3 > num1)
                {
                    Console.Write("Third number " + num3 + " is the largest!\n");
                }

                else if (num2 > num3)
                    Console.Write("Second number " + num2 + " is the largest!\n");
                else
                    Console.Write("Third number " + num3 + " is the largest!\n");
            }
        }
    }
}
