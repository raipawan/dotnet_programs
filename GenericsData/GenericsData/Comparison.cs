using System;
using System.Collections.Generic;

namespace GenericsData
{
    class Comparison
    {
        public void checkMax(T first, T second, T third)
        {
            if (Comparer<T>.Default.Compare(first, second) > 0 && Comparer<T>.Default.Compare(first, third) > 0)
                Console.WriteLine("Maximum is " + first);
            if (Comparer<T>.Default.Compare(third, second) > 0 && Comparer<T>.Default.Compare(third, first) > 0)
                Console.WriteLine("Maximum is " + third);
            if (Comparer<T>.Default.Compare(second, first) > 0 && Comparer<T>.Default.Compare(second, third) > 0)
                Console.WriteLine("Maximum is " + second);
        }

        public static implicit operator Comparison<object>(Comparison v)
        {
            throw new NotImplementedException();
        }
    }
}
