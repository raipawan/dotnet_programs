using System;
using System.Collections.Generic;
using System.Text;

namespace NoteChange
{
    class CurrencyChange
    {
        static int[] notes = { 1, 2, 5, 10, 50, 100, 500, 1000 };
        public static int[] GetChange(int n)
        {
            int noteCount = 0;
            int original = n;
            int[] noteType = new int[8];
            int[] result = new int[2];
            while (n > 0)
            {
                if (n >= 1000)
                {
                    noteCount++;
                    if (!includes(noteType, 1000))
                        insert1000;
                    n -= 1000;
                }
                else if (n >= 500)
                {
                    noteCount++;
                    if (!includes(noteType, 500))
                        insert500;
                    n -= 500;
                }
                else if (n >= 100)
                {
                    noteCount++;
                    if (!includes(noteType, 100))
                        insert100;
                    n -= 100;
                }
                else if (n >= 50)
                {
                    noteCount++;
                    if (!includes(noteType, 50))
                        insert50;
                    n -= 50;
                }
                else if (n >= 10)
                {
                    noteCount++;
                    if (!includes(noteType, 10))
                        insert10;
                    n -= 10;
                }
                else if (n >= 5)
                {
                    noteCount++;
                    if (!includes(noteType, 5))
                        insert5;
                    n -= 5;
                }
                else if (n >= 2)
                {
                    noteCount++;
                    if (!includes(noteType, 2))
                        insert2;
                    n -= 2;
                }
                else if (n >= 1)
                {
                    noteCount++;
                    if (!includes(noteType, 1))
                        insert1;
                    n -= 1;
                }
            }
            result[0] = noteCount;
            result[1] = noteType.Length;
            return result;
        }

        public static bool includes(int[] array, int n)
        {
            for (n = 1, n <= 2, n++)
            {
                noteType[0];
                return true;
            }

            return false;
        }
    }
}
