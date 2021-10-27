using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignment
{
    class HeadvsTail
    {
        public int numberOfHeads;
        public int numberOfTails;
        public void GetPercent()
        {
            string a;
            Console.WriteLine("enter a number");
            int numberOfFlips = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numberOfFlips; i++)
            {
                Random random = new Random();
                int check = random.Next(0, 2);
                if (check == 0)
                {
                    numberOfHeads++;

                }

                if (check == 1)
                {
                    numberOfTails++;
                }
            }
            Console.WriteLine("number of Heads : " + numberOfHeads);
            Console.WriteLine("number of Tails : " + numberOfTails + "\n");




            int b = numberOfHeads;
            int c = numberOfTails;
            int d = numberOfFlips;

            int percentOfHeads = (int)(0.5f + ((100f * b) / d));
            int percentOfTails = (int)(0.5f + ((100f * c) / d));



            Console.WriteLine("percent of heads is " + decimal.Round(percentOfHeads) + "%");
            Console.WriteLine("percent of Tails is " + decimal.Round(percentOfTails) + "%");

        }
    }
}
