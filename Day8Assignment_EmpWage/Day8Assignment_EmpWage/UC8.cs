using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{

    class Company
    {
        public bool isFullTime = true;
        public int wagePerHour;
        public int totalWorkingDay;
        public string CompanyName;
        public int WorkHourPerDay;
        public int TotalWage;

        public Company(int wagePerHour, int WorkHourPerDay, int totalWorkingDay, string companyName)
        {
            this.totalWorkingDay = totalWorkingDay;
            this.CompanyName = companyName;
            this.wagePerHour = wagePerHour;
            this.WorkHourPerDay = WorkHourPerDay;
        }
    }
    class UC8 : Company
    {

        //string CompanyName;

        public UC8(int wagePerHour, int totalWorkingDay, int WorkHourPerDay, string companyName) : base(wagePerHour, WorkHourPerDay, totalWorkingDay, companyName)
        {

        }
        public void GetTotalWage()
        {
            int totalWorkHour = this.GetTotalWorkHour(WorkHourPerDay);
            int empWage = totalWorkHour * this.wagePerHour;
            this.TotalWage = empWage;
            Console.WriteLine("Company: " + this.CompanyName + "total working hour :" + totalWorkHour + " and total wage of employee for this month :" + empWage);
        }

        public int GetTotalWorkHour(int workHourPerDay)
        {
            int totalWorkHour = workHourPerDay * this.totalWorkingDay;
            if (totalWorkHour > 100)
                totalWorkHour = 100;

            return totalWorkHour;
        }
    }
}
