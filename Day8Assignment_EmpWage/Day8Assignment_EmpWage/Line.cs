using System;
using System.Collections.Generic;
using System.Text;

namespace Day8Assignment_EmpWage
{
    class Line : IComparable<Line>
    {
        Point p1;
        Point p2;

        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public double GetLength()
        {
            int x1 = this.p1.x;
            int y1 = this.p1.y;
            int x2 = this.p2.x;
            int y2 = this.p2.y;

            double lengthOfline = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lengthOfline;
        }

        public int CompareTo(Line other)
        {
            double length1 = this.GetLength();
            double length2 = other.GetLength();

            if (length1 > length2)
                return 1;
            else if (length2 > length1)
                return -1;
            return 0;

        }
    }
}
