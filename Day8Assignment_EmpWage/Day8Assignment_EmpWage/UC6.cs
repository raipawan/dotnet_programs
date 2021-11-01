using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{
    public class UC6
    {
        public void MaxWageForAMonth()
        {
            const int isFullTime = 1;
            const int isPartTime = 2;
            const int wagePerHour = 20;
            const int totalWorkingDay = 20;
            int workHourPerDay;
            int empWage;
            int totalWorkHour;

            Random random = new Random();
            int check = random.Next(0, 3);

            switch (check)
            {
                case isFullTime:

                    workHourPerDay = 8;
                    break;


                case isPartTime:

                    workHourPerDay = 4;

                    break;

                default:
                    workHourPerDay = 0;
                    break;
            }
            totalWorkHour = workHourPerDay * totalWorkingDay;

            if (totalWorkHour > 100)
                totalWorkHour = 100;

            empWage = totalWorkHour * wagePerHour;
            Console.WriteLine("total working hour is " + totalWorkHour + " and  total wage of employee for this month is " + empWage);

        }
    }
}
