using System;

namespace practice 
{

    public class EmployeeWageBuilder
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        int empRatePerHr;
        int noOfWorkingDays;
        int noOfWorkingHr;
        string companyName;
        public static int noOfCompany = 5;
public  static EmployeeWageBuilder[] compniesdetails;

        public EmployeeWageBuilder(int empRatePerHr, int noOfWorkingDays, int noOfWorkingHr, string companyName)
        {
            this.companyName = companyName;
            this.empRatePerHr = empRatePerHr;
            this.noOfWorkingDays = noOfWorkingDays;
            this.noOfWorkingHr = noOfWorkingHr;
        }

        public void calculateWage()
        {
            int wage = this.empRatePerHr * this.noOfWorkingDays * this.noOfWorkingHr;
            Console.WriteLine("Average wage for employee in company "+ this.companyName + " " + wage);
        }

        static public void initializeArray()
        {
            compniesdetails = new EmployeeWageBuilder[noOfCompany];
            compniesdetails[0] = new EmployeeWageBuilder(20, 20, 9, "Adani Power");
            compniesdetails[1] = new EmployeeWageBuilder(10, 21, 8, "ITC");
            compniesdetails[2] = new EmployeeWageBuilder(20, 20, 7,"Bajaj Electronics");
            compniesdetails[3] = new EmployeeWageBuilder(400,20,9, "Reliance");
            compniesdetails[4] = new EmployeeWageBuilder(20, 20, 9, "TATA Power");
        }
    }
}
