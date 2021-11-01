using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class ReverseANumber
    {
        public void GetReverse()
        {
            Console.WriteLine("enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem;
            int newNumber = 0;

            while (n > 0)
            {
                rem = n % 10;
                n = n / 10;
                newNumber = newNumber * 10 + rem;
            }
            Console.WriteLine("reversed number is : " + newNumber);
        }
    }
}
