using System;

namespace LearningNlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NLog nlog = new NLog();
            nlog.LogDebug("run");
        }
    }
}
