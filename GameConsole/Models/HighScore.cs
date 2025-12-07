using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Towel;

namespace GameConsole.Models
{
    internal class HighScore
    {
        private string gameName;
        private int score;
        private DateTime dateTime;

        public string game_Name
        {
            get { return gameName; }
            set { gameName = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public HighScore(string gameName, int score)
        {
            this.gameName = gameName;
            this.score = score;
            this.dateTime = DateTime.Now;
        }
    }
}
