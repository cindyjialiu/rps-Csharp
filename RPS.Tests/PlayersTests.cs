using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class PlayersTest
    {
        [TestMethod]
        public void LookUpMovesFromIndexZero()
        {
            Assert.AreEqual(moves.rock, Players.LookUpMovesFromIndex(0));
        }
    }
}
