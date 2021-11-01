using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{
    class UC2
    {
        public void WagePerDay()
        {
            const int isPresent = 1;
            const int wagePerHour = 20;
            const int workHourPerDay = 8;
            int empWage;
            empWage = wagePerHour * workHourPerDay;


            Random random = new Random();
            int check = random.Next(0, 2);

            if (check == isPresent)
                Console.WriteLine("employee is present and his daily wage is " + empWage);
            else
                Console.WriteLine("employee is absent so his daily wage is zero");
        }
    }
}
