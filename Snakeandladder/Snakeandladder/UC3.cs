using System;
using System.Collections.Generic;
using System.Text;

namespace Snakeandladder {
   public class UC3 {  
        const int FINAL_POSITION = 100;
        const int INITIAL_POSITION = 0;
        const int LADDER = 0;
        const int SNAKE = 1;
        const int FIX = 2;
        int position = 0;
        int totalCount;
        Random random = null;

        public UC3()
        {
            this.position = INITIAL_POSITION;
            this.random = new Random();
            this.totalCount = INITIAL_POSITION;
        }

        private int nextMove()
        {
            int DiceNumber = this.random.Next(1, 7);
            int Nextmove = this.random.Next(0, 3);
            this.totalCount++;



            if (Nextmove == LADDER)
                DiceNumber = DiceNumber;
            else if (Nextmove == SNAKE)
                DiceNumber = DiceNumber * -1;
            else
                DiceNumber = 0;
            
            Console.WriteLine(DiceNumber);
            return DiceNumber;
        }

        public void updatePsition()
        {
            int move = nextMove();
            int nextPos = this.position + move;
            if(nextPos == this.position)
            {}
            else if ((nextPos) < INITIAL_POSITION)
                this.position = INITIAL_POSITION;
            else if (nextPos <= FINAL_POSITION)
                this.position = nextPos;
            Console.WriteLine("Move No. :" + this.totalCount + " Position :" + this.position);
        }

        public bool isWin()
        {
            return this.position == FINAL_POSITION;
        }

        public int getTotalTurns()
        {
            return this.totalCount;
        }
    }
}
