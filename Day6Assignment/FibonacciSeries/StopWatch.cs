using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Day6Assignment
{
    public class StopWatch
    {
        public void GetTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();
            TimeSpan tspan = stopWatch.Elapsed;
            string time = String.Format(" {0:00}:{1:00}:{2:00}.{3:00} ",
            tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
            Console.WriteLine(" Elapsed time is  " + time);

        }
    }
}
