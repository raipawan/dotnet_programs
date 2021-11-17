using System;

namespace TIicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.CreateBoard();

            ticTacToe.Input();

        }
    }
}
