using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{
    class UC7
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        const int wagePerHour = 20;
        const int totalWorkingDay = 20;
        private static Random random = new Random();
        //string CompanyName;

        public void GetWorkingHour()
        {
            int workHourPerDay = UC7.GetWorkHourPerDay();
            int totalWorkHour = UC7.GetTotalWorkHour(workHourPerDay);
            int empWage = totalWorkHour * UC7.wagePerHour;
            Console.WriteLine("total working hour is " + totalWorkHour + " and  total wage of employee for this month is " + empWage);
        }

        public static int GetWorkHourPerDay()
        {
            int check = UC7.random.Next(0, 3);
            int workHourPerDay = 0;

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
            return workHourPerDay;
        }

        public static int GetTotalWorkHour(int workHourPerDay)
        {
            int totalWorkHour = workHourPerDay * UC7.totalWorkingDay;
            if (totalWorkHour > 100)
                totalWorkHour = 100;

            return totalWorkHour;
        }
    }
}
