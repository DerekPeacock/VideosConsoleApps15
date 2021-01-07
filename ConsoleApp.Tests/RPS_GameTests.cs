using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App05;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class RPS_GameTests
    {

        private Game game = new Game("Tim");

        [TestMethod]
        public void TestGameStart()
        {
            game.Start();

            Assert.AreEqual(0, game.Human.Score);
            Assert.AreEqual(0, game.Computer.Score);
            Assert.AreEqual(1, game.Round);
            
            Assert.AreEqual(GamePlayers.Player, game.CurrentPlayer.PlayerType);

            Assert.AreEqual("Gita", game.Human.Name);
            Assert.AreEqual("Computer", game.Computer.Name);
        }
    }
}
