using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{
    class UC3
    {
        public void AddPartTime()
        {
            const int isFullTime = 1;
            const int isPartTime = 2;
            const int wagePerHour = 20;
            int workHourPerDay;
            int empWage;

            Random random = new Random();
            int check = random.Next(0, 3);

            if (check == isFullTime)
            {
                workHourPerDay = 8;
                empWage = wagePerHour * workHourPerDay;
                Console.WriteLine("employee is full time present and his daily wage is " + empWage);

            }
            else if (check == isPartTime)
            {
                workHourPerDay = 4;
                empWage = wagePerHour * workHourPerDay;
                Console.WriteLine("employee is part time and his daily wage is " + empWage);


            }
            else
            {
                workHourPerDay = 0;
                empWage = wagePerHour * workHourPerDay;
                Console.WriteLine("employee is absent so his daily wage is zero");

            }
        }
    }
}
