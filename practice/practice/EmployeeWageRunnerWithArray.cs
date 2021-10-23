using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class EmployeeWageRunnerWithArray
    {
        public static void Main(string [] args)
        {
            EmployeeWageBuilder.initializeArray();
            for(int i=0;i<EmployeeWageBuilder.noOfCompany; i++)
            {
                EmployeeWageBuilder.compniesdetails[i].calculateWage();
            }
        }
    }
}
