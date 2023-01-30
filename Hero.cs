using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        string username;
        int level;

        public string Username { get => username; set => username = value; }
        public int Level { get => level; set => level = value; }

        public Hero(string username, int level)
        {
            Username = this.username;
            Level = this.level;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level} ";
        }
    }
}
