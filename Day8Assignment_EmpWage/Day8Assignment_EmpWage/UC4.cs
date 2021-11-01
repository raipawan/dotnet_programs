using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{
    class UC4
    {
        public void UsingSwitchCase()
        {
            const int isFullTime = 1;
            const int isPartTime = 2;
            const int wagePerHour = 20;
            int workHourPerDay;
            int empWage;

            Random random = new Random();
            int check = random.Next(0, 3);
            switch (check)
            {
                case isFullTime:

                    workHourPerDay = 8;
                    empWage = wagePerHour * workHourPerDay;
                    Console.WriteLine("employee is present and his daily wage is " + empWage);
                    break;


                case isPartTime:

                    workHourPerDay = 4;
                    empWage = wagePerHour * workHourPerDay;
                    Console.WriteLine("employee is part time and his daily wage is " + empWage);
                    break;

                default:
                    workHourPerDay = 0;
                    empWage = wagePerHour * workHourPerDay;
                    Console.WriteLine("employee is absent so his daily wage is zero");
                    break;

            }
        }
    }
}