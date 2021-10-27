using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignment
{
    class QuotientandRemainder
    {
        public void getAnswer()
        {
            Console.WriteLine("enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = number / divisor;
            int remainder = number % divisor;

            Console.WriteLine("Number:{0} Divisor:{1}", number, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
