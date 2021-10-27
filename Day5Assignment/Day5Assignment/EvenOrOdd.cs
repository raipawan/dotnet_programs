using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignment
{
    class EvenOrOdd
    {
        public void getAnswer()
        {
            Console.WriteLine("Please Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even Number");
            }
            else
            {
                Console.WriteLine(number + " is Odd Number");
            }
        }
    }
}

