using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class PlayersTest
    {
        [TestMethod]
        public void RandomComputerPlayerPlaysRock()
        {
            Assert.AreEqual(moves.paper, Players.RandomComputerPlayer());
        }
    }
}
