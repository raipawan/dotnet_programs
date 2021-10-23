using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_NAME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NO_OF_WORKING_DAYS = 20;
            int empWage = 0;

            int empHr = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_NAME)

            {
                empHr = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHr = 4;
            }
            else
            {
                empHr = 0;
            Console.WriteLine(empHr);
                Console.ReadKey();
        }
    }
}
