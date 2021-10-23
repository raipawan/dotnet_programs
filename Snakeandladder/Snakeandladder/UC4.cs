using System;
using System.Collections.Generic;
using System.Text;

namespace Snakeandladder
{
    class UC4
    {
        const int FINAL_POSITION = 100;
        const int INITIAL_POSITION = 0;
        const int LADDER = 0;
        const int SNAKE = 1;
        const int FIX = 2;
        int position1;
        int position2;
        int totalCount;
        Random random = null;
        bool player1Turn = true;
       

        public UC4()
        {
            this.position1 = INITIAL_POSITION;
            this.position2 = INITIAL_POSITION;
            this.random = new Random();
            this.totalCount = INITIAL_POSITION;
        }
        public void startGame()
        {
            while(getWinner() == 0)
            {
                updatePsition();
                this.player1Turn = !this.player1Turn;
            }
            int winner = getWinner();
            Console.WriteLine("Winner is Player " + winner);
        }

        private int nextMove()
        {
            int DiceNumber = this.random.Next(1, 7);
            int Nextmove = this.random.Next(0, 3);

            if (Nextmove == LADDER)
                DiceNumber = DiceNumber;
            else if (Nextmove == SNAKE)
                DiceNumber = DiceNumber * -1;
            else
                DiceNumber = 0;

            return DiceNumber;
        }

        public void updatePsition()
        {
            int position;
            int player = this.player1Turn ? 1 : 2;
            if (this.player1Turn)
            {
                position = this.position1;
                this.totalCount++;
            }
            else
                position = this.position2;
            
            int move = nextMove();
            int nextPos = position + move;
            if (nextPos == position)            { }
            else if ((nextPos) < INITIAL_POSITION)
                position = INITIAL_POSITION;
            else if (nextPos <= FINAL_POSITION)
                position = nextPos;

            if (this.player1Turn)
                this.position1 = position;
            else
                this.position2 = position;

            Console.WriteLine("Player :" + player + " Move No. :" + this.totalCount + " Position :" + position);
        }

        public int getWinner()
        {
            if (this.position1 == FINAL_POSITION)
                return 1;
            if (this.position2 == FINAL_POSITION)
                return 2;
            return 0;
        }
        public int getTotalTurns() 
        { 
            return this.totalCount;
        }
    }
}
