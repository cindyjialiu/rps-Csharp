using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class PlayersTest
    {
        [TestMethod]
        public void RandomComputerPlayerPlaysRock()
        {
            Players player = new Players();
            Assert.AreEqual(moves.paper, player.RandomComputerPlayer());
        }
    }
}
