using System;
using System.Collections.Generic;
using System.Text;

namespace headsVsTails
{
    class UC
    {
        public int numberOfHeads;
        public int numberOfTails;


        public void GetPercent()
        {
            string a;
            Console.WriteLine("enter a number");
            a = Console.ReadLine();
            int numberOfFlips = Convert.ToInt32(a);


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





            int b = numberOfHeads;
            int c = numberOfTails;
            int d = numberOfFlips;

            double percentOfHeads = b * 100 / d;
            double percentOfTails = c * 100 / d;


            Console.WriteLine("percent of heads is " + percentOfHeads + "%");
            Console.WriteLine("percent of heads is " + percentOfTails + "%");

        }

    }
}




