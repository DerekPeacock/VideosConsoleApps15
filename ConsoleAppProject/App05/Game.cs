using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
    /// <summary>
    /// 
    /// </summary>
    public class Game
    {
        public const int MAXIMUM_ROUND = 10;

        public int Round { get; set; }

        public Player Human { get; }

        public Player Computer { get; }

        public Player CurrentPlayer { get; set; }

        public Player Winner { get; set; }

        public Game(string name)
        {
            Human = new Player("Gita", GamePlayers.Player);
            Computer = new Player("Computer", GamePlayers.Computer);

            Round = 0;
        }

        public void Start()
        {
            Round = 1;
            CurrentPlayer = Human;

            Human.Score = 0;
            Computer.Score = 0;
        }
    }
}
