﻿using System;

namespace Linecomparison
{
    class Program
    {
        public static void Main(string[] args)
        {


            double linelength(double x1, double y1, double x2, int y2)
            {
                double lengthOfline = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                return (double)lengthOfline;
            }
            double line1 = linelength(4, 6, 7, 8);
            double line2 = linelength(4, 6, 9, 8);
            Console.WriteLine("welcome to line comparison");

            Console.WriteLine("length of line1 is " + line1 + " length of line2 is " + line2);

            if (line1 == line2)
            {
                Console.WriteLine("lines are equal");
            }
            else if (line1 > line2)
            {
                Console.WriteLine("line 1 is greater");
            }
            else
            {
                Console.WriteLine("line 2 is greater");
            }



        }
    }
}
