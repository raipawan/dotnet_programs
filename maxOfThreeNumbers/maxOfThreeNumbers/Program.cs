using System;

namespace maxOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
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
                    Console.Write("Number one" + num1 + " is the largest\n");
                }
                else
                {
                    Console.Write("Number three" + num3 + " is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two" + num2 + " is the largest!\n");
            else
                Console.Write("Number three" + num3 + " is the largest!\n");
        }
    }
}