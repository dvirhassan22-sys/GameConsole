using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class User
    {
        private string username;
        private string name;
        private string password;
        private List<HighScore> highScores;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(string username, string name, string password)
        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.highScores = new List<HighScore>();
        }
    }
}
