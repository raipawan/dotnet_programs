using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignment
{
    class ConsonantOrVowel
    {
        public void getAnswer()
        {
            Console.WriteLine("Enter any character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }
}
