using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    class AnalyzeMood
    {
        public static string CheckMood(string message)
        {
            if (message.Contains("happy"))
                return "happy";
            else
                return "sad";
        }
    }
}
