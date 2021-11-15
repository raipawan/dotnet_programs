using System;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            var input = Console.ReadLine();
            int n;
            try
            {
                n = Convert.ToInt32(input);
                Console.WriteLine("input is : " + n);
            }
            catch (Exception)
            {
                Console.WriteLine("wrong input");
            }

        }
    }
}
