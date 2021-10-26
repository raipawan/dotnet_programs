using System;
using System.Collections.Generic;
using System.Text;

namespace leapYear
{
    public class Class1
    {



        public void Leapyear()
        {
            Console.WriteLine("enter year :");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (9999 < Year || Year < 1000)
            {
                Console.WriteLine("year is not valid");
            }
            else if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
            {
                Console.WriteLine(Year + " is leapyear");
            }
            else
            {
                Console.WriteLine(Year + "  is not leapyear");
            }
            Console.ReadLine();
        }
    }
}