using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    public class CoupenNumbers
    {
        public int GetCoupenNumbers()
        {
            LinkedList<int> list = this.InitiateInput();
            bool isContains = false;
            int count = 0;
            while (isContains == false)
            {
                int x = CoupenNumbers.GetRandom();
                isContains = list.Contains(x);
                count++;
            }
            Console.WriteLine(count);
            return count;


        }
        public LinkedList<int> InitiateInput()
        {
            Console.WriteLine("enter input : ");
            string input = Console.ReadLine();
            string[] arr = input.Trim().Split(" ");
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                list.AddLast(Convert.ToInt32(arr[i]));
            }
            return list;
        }

        public static int GetRandom()
        {
            Random random = new Random();
            int coupens = random.Next(1, 99);
            return coupens;
        }



    }

}
