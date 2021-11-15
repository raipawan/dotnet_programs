using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{

    class Solution
    {
        //Complete this function
        //Function to check if there is a pair with the given sum in the array.
        public int[] duplicates(int[] arr, int n)
        {
            Array.Sort(arr);
            int[] result = new int[n];
            int k = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            int[] finalRes = new int[k];
            while (k > 0)
            {
                finalRes[k - 1] = result[k - 1];
                k--;
            }
            return finalRes;

        }

    }
}
