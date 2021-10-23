using System;
using System.Collections.Generic;
using System.Text;

namespace Snakeandladder
{
    class UC4
    {
        
        const int INITIAL_POSITION = 0;
        const int FINAL_POSITION = 100;
        const int LADDER = 0;
        const int SNAKE = 1;
        const int FIX = 2;
        int totalCount;
        Random random = null;
        bool player1Turn = true;
        Player P1;
        Player P2;
       

        public UC4(string p1Name, string p2Name)
        {
            this.random = new Random();
            this.totalCount = INITIAL_POSITION;
            this.P1 = new Player(p1Name, INITIAL_POSITION);
            this.P2 = new Player(p2Name, INITIAL_POSITION);
        }
        public void startGame()
        {
            while(getWinner() == null)
            {
                updatePsition();
                this.player1Turn = !this.player1Turn;
            }
            Player winner = getWinner();
            Console.WriteLine("Winner is :" + winner.getName() );
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
            Player player = this.player1Turn ? P1 : P2;
            if (this.player1Turn)
            {
                position = this.P1.score;
                this.totalCount++;
            }
            else
                position = this.P2.score;
            
            int move = nextMove();
            int nextPos = position + move;
            if (nextPos == position)            { }
            else if ((nextPos) < INITIAL_POSITION)
                position = INITIAL_POSITION;
            else if (nextPos <= FINAL_POSITION)
                position = nextPos;

            if (this.player1Turn)
                this.P1.score = position;
            else
                this.P2.score = position;

            Console.WriteLine("Player :" + player.getName() + " Move No. :" + this.totalCount + " Position :" + position);
        }

        public Player getWinner()
        {
            if (this.P1.isWin())
                return this.P1;
            if (this.P2.isWin())
                return this.P2;
            return null;
        }
        public int getTotalTurns() 
        { 
            return this.totalCount;
        }
    }
}
