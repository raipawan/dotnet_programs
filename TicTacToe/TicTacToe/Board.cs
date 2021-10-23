using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        int[,] board = new int[3, 3];
        bool player1Turn = true;

        public void startGame()
        {
            getInputAndUpdateBoard();
        }
        public void getInputAndUpdateBoard()
        {
            for (int k = 0; k < 9; k++)
            {
                Console.WriteLine("------------");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("| " + this.board[i, 0] + " |");
                    Console.Write("| " + this.board[i, 1] + " |");
                    Console.WriteLine("| " + this.board[i, 2] + " |");
                }
                Console.WriteLine();
                int player = this.player1Turn ? 1 : 2;
                Console.WriteLine("Give input for Player " + player);
                string input = Console.ReadLine();
                string[] args = input.Split(" ");
                int row = Convert.ToInt32(args[0]) - 1;
                int col = Convert.ToInt32(args[1]) - 1;
                if (player == 1)
                {
                    this.board[row, col] = 1;
                }
                else
                {
                    this.board[row, col] = 2;
                }
                int winner = getWinner();
                if (winner != 0)
                {
                    Console.WriteLine("Winner is Player :" + winner);
                    break;
                }
                this.player1Turn = !this.player1Turn;
            }
        }

        public int getWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((this.board[i, 1] == this.board[i, 2]) && (this.board[i, 2] == this.board[i, 0]) && (this.board[i, 2] != 0))
                    return this.board[i, 2];

                if ((this.board[0, i] == this.board[1, i]) && (this.board[1, i] == this.board[2, i]) && (this.board[2, i] != 0))
                    return this.board[i, 2];
            }

            if ((this.board[0, 0] == this.board[1, 1]) && (this.board[1, 1] == this.board[2, 2]) && (this.board[2, 2] != 0))
                return this.board[2, 2];

            if ((this.board[0, 2] == this.board[1, 1]) && (this.board[1, 1] == this.board[2, 0]) && (this.board[2, 0] != 0))
                return this.board[2, 0];

            return 0;
        }
    }
}
