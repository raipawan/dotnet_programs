using System;
using System.Collections.Generic;

namespace Day8Assignment_EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            /* UC1 uC1 = new UC1();
             uC1.present();*/

            /* UC2 uC2 = new UC2();
             uC2.WagePerDay();*/

            /* UC3 uC3 = new UC3();
             uC3.AddPartTime();*/

            /* UC4 uC4 = new UC4();
             uC4.UsingSwitchCase();*/

            /*UC5 uC5 = new UC5();
            uC5.WageForAMonth();*/

            /*UC6 uC6 = new UC6();
            uC6.MaxWageForAMonth();*/

            /*UC7 uC7 = new UC7();
            uC7.GetWorkingHour();*/

            LinkedList<UC8> list = new LinkedList<UC8>();
            list.AddLast(new UC8(50, 20, 7, "Google"));
            list.AddLast(new UC8(45, 21, 7, "Amazon"));
            list.AddLast(new UC8(48, 19, 7, "Microsoft"));
            list.AddLast(new UC8(40, 20, 7, "Flipkart"));
            list.AddLast(new UC8(42, 20, 7, "Adobe"));
            list.AddLast(new UC8(45, 20, 7, "Oracle"));
            list.AddLast(new UC8(40, 21, 7, "Paytm"));
            list.AddLast(new UC8(30, 20, 7, "Zomato"));
            list.AddLast(new UC8(25, 22, 7, "Swiggy"));
            list.AddLast(new UC8(35, 20, 7, "Pinelabs"));

            foreach (UC8 uc in list)
            {
                uc.GetTotalWage();
            }

            string input = "Zomato";

            foreach (UC8 uc in list)
            {
                if (uc.CompanyName.Equals(input))
                {
                    Console.WriteLine("total wage for " + input + " employee :" + uc.TotalWage);
                }
            }

            /*Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 3);
            Point p3 = new Point(2, 1);


            Line line1 = new Line(p1, p2);
            Line line2 = new Line(p1, p3);

            List<Line> list = new List<Line>();
            list.Add(line1);
            list.Add(line2);

            int x = line1.CompareTo(line2);
            if (x == 1)
                Console.WriteLine("length of 1st line is greater than line2 length");
            else if (x == -1)
                Console.WriteLine("length of 2nd line is greater than line1 length");
            else
                Console.WriteLine("length of both the lines are equal");
*/
        }
    }
}
