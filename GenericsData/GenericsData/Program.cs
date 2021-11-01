using System;

namespace GenericsData
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
             int[] intArray = { 1, 2, 3, 4, 5 };
             char[] charArray = { 'A', 'B', 'C', 'D' };
             double[] doubleArray = { 1.2, 2.4, 3.6, 4.8 };
             printArray printArray = new printArray();
             printArray.PrintArray(intArray);*/

            Comparison<dynamic> comparison = new Comparison();
            comparison.checkMax(1, 2, 3);

        }
    }
}

