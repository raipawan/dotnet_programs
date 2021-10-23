using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int PAY_PER_HOUR = 20;
            const int WORKING_DAY = 20;
            int WORKING_HOUR = 0;
            int EmpWage = 0;
            const int MAX_HOUR = 100;
            int totalWorkHour;

            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

            switch (EmpCheck)
            {
                case 1:
                    WORKING_HOUR = 8;
                    Console.WriteLine("empolyee is present");
                    break;

                case 2:
                    WORKING_HOUR = 4;
                    Console.WriteLine("empolyee is part time");
                    break;

                default:
                    WORKING_HOUR = 0;
                    Console.WriteLine("empolyee is absent");
                    break;
            }
            totalWorkHour = WORKING_DAY * WORKING_HOUR;

            if (totalWorkHour >= 100)
            {
                totalWorkHour = 100;
            }
            EmpWage = totalWorkHour * PAY_PER_HOUR;

            Console.WriteLine("total employee wage for " + totalWorkHour + " hour is : " + EmpWage);

        }
    }
}
