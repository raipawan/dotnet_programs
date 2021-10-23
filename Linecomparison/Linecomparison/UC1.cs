using System;
using System.Collections.Generic;
using System.Text;

namespace Linecomparison
{
    class UC1
    {

        public float linelength(int x1, int y1, int x2, int y2)
        {
            double lengthOfline = Math.Sqrt((x2 - x1) + (y2 - y1));
            return (float)lengthOfline;
        }


        public int compare(float line1, float line2)
        {
            if (line1 == line2)
            {
                return 0;
            }
            else if (line1 > line2)
            {
                return 1;
            }
            else;
            return 2;

            line1 = linelength(4, 6, 7, 8);
            line2 = linelength(8, 7, 5, 3);

        }

    }
}
