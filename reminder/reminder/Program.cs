using System;

namespace reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 50;
            int divisor = 8;

            int quotient = number / divisor;
            int remainder = number % divisor;

            Console.WriteLine("Number:{0} Divisor:{1}", number, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
