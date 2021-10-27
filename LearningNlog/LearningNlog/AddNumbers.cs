using System;
using System.Collections.Generic;
using System.Text;

namespace LearningNlog
{
    public class AddNumbers
    {
        NLog log = new NLog();
        public int sum(int a, int b)
        {
            log.LogInfo("Value of param is" + a + " " + b);
            if (a == 0 || b == 0)
            {
                log.LogDebug("Debugging is succes:Sum");
                log.LogError("Expecting value of a and b");
                return 0;
            }
            int c = a + b;
            log.LogDebug("Debugging is succes:Sum");
            log.LogDebug("succes method passed r");
            Console.ReadLine();

        }
    }
}
