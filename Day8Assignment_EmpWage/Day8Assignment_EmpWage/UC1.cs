using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{
    public class UC1
    {
        public void present()
        {
            const int isPresent = 1;



            Random random = new Random();

            int check = random.Next(0, 2);

            if (check == isPresent)
                Console.WriteLine("employee is present");
            else
                Console.WriteLine("employee is absent");
        }
    }
}