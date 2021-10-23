using System;
using System.Collections.Generic;
using System.Text;

namespace Snakeandladder
{
    class Player
    {
        const int FINAL_SCORE = 100;
        private string name;
        public int score;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
        public string getName()
        {
            return this.name;
        }

        public bool isWin()
        {
            return this.score == FINAL_SCORE;
        }


    }

}
