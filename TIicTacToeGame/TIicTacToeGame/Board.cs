using System;
using System.Collections.Generic;
using System.Text;

namespace TIicTacToeGame
{
    class Board
    {
        int[] board = new int[10];
        public void CreateBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("|  |");
                }
                Console.WriteLine("\n");

            }
        }
    }
}
