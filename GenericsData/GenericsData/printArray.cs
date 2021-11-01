using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsData
{
    class printArray
    {
        public void PrintArray(int[] input)
        {
            foreach (var element in input)
            {
                Console.WriteLine(element);
            }
        }
    }
}
