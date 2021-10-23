using System;

namespace Linecomparison
{
    class Program
    {
        public static void Main(string[] args)
        {


            float linelength(int x1, int y1, int x2, int y2)
            {
                double lengthOfline = Math.Sqrt((x2 - x1) + (y2 - y1));
                return (float)lengthOfline;
            }
            float line1 = linelength(4, 6, 7, 8);
            float line2 = linelength(4, 6, 9, 8);
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
