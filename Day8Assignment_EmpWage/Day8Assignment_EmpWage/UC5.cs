using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{
    class UC5
    {
        public void WageForAMonth()
        {
            const int isFullTime = 1;
            const int isPartTime = 2;
            const int wagePerHour = 20;
            const int totalWorkingDay = 20;
            int workHourPerDay;
            int empWage;

            Random random = new Random();
            int check = random.Next(0, 3);

            switch (check)
            {
                case isFullTime:

                    workHourPerDay = 8;
                    empWage = wagePerHour * workHourPerDay * totalWorkingDay;
                    Console.WriteLine("employee is present and his monthly wage is " + empWage);
                    break;


                case isPartTime:

                    workHourPerDay = 4;
                    empWage = wagePerHour * workHourPerDay * totalWorkingDay;
                    Console.WriteLine("employee is part time and his monthly wage is " + empWage);
                    break;

                default:
                    workHourPerDay = 0;
                    empWage = wagePerHour * workHourPerDay * totalWorkingDay;
                    Console.WriteLine("employee is absent so his monthly wage is zero");
                    break;

            }
        }
    }
}
