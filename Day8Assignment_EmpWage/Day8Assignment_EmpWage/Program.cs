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

            Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 3);
            Point p3 = new Point(2, 1);
            Point p4 = new Point(21, 1);
            Point p5 = new Point(2, 12);
            Point p6 = new Point(20, 1);
            Point p7 = new Point(2, 15);


            Line line1 = new Line(p1, p2);
            Line line2 = new Line(p1, p3);
            Line line3 = new Line(p1, p4);
            Line line5 = new Line(p1, p5);
            Line line6 = new Line(p1, p6);
            Line line4 = new Line(p1, p7);
            Line line7 = new Line(p2, p3);
            Line line8 = new Line(p4, p3);

            List<Line> list = new List<Line>();
            list.Add(line1);
            list.Add(line2);
            list.Add(line4);
            list.Add(line3);
            list.Add(line5);
            list.Add(line6);
            list.Add(line7);
            list.Add(line8);

            list.Sort();
            foreach (Line line in list)
                Console.WriteLine(line.GetLength());

            int x = line1.CompareTo(line2);
            if (x == 1)
                Console.WriteLine("length of 1st line is greater than line2 length");
            else if (x == -1)
                Console.WriteLine("length of 2nd line is greater than line1 length");
            else
                Console.WriteLine("length of both the lines are equal");

        }
    }
}
