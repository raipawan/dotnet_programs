using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class GiveInput
    {

        public void Input()
        {
            char[] board = new char[10];

            for (int i = 0; i < board.Length; i++)
            {
                char pavan = 'X';
                char Computer = 'O';

                Console.WriteLine("give input for player Pavan ");
                Console.WriteLine("for which position you want to update");
                int position1 = Convert.ToInt32(Console.ReadLine());
                board[position1] = pavan;

                Console.WriteLine("give input for player Computer");
                Console.WriteLine("which position you want to update");
                int position2 = Convert.ToInt32(Console.ReadLine());
                board[position2] = Computer;

            }
        }
    }
}
