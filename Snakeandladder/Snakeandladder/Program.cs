using System;

namespace Snakeandladder
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*UC3 uc3 = new UC3();
             while(!uc3.isWin())
             {
                 uc3.updatePsition();
             }

             Console.WriteLine("You have won the game in " + uc3.getTotalTurns() + " turns");*/
           // Console.WriteLine(args[0]);
            UC4 uc4 = new UC4("Sanjeev", "Pavan");
            uc4.startGame();
       

        }
    }
}
