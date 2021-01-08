using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App05
{
    /// <summary>
    /// 
    /// </summary>
    public class GameView
    {
        private Game game;

        /// <summary>
        /// Controls the sequence of events in one round of
        /// game play, and repeats that until the game ends
        /// </summary>
        public void Play()
        {
            bool wantToQuit = true;

            do
            {
                StartGame();
                
                GetPlayerChoice();
                DisplayChoice(game.Human.Choice);
                
                game.MakeComputerChoice();
                DisplayChoice(GameChoices.Scissors);

                game.ScoreRound();

                if(game.Round == game.LastRound)
                {
                    Console.WriteLine();

                }

            } while (!wantToQuit);
        }

        private void DisplayChoice(GameChoices choice)
        {
            if(choice == GameChoices.Scissors)
            {
                GameImages.DrawScissors(10, 10);
            }
        }

        private void GetPlayerChoice()
        {
        }

        public void StartGame()
        {
            SetupConsole();

            ConsoleHelper.OutputHeading("  Rock-Paper-Scissors Game");

            if(game == null)
            {
                Console.Write(" Please enter your name > ");
                string name = Console.ReadLine();

                game = new Game("Derek");
            }

            game.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetupConsole()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();
        }
    }
}
