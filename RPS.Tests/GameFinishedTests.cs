using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class GameFinishedTests
    {
        [TestMethod]
        public void GameStatusIsDraw()
        {
            var History = new wonDrawLost[] { wonDrawLost.draw, wonDrawLost.draw };
            Assert.AreEqual(gameResult.draw, GameFinished.GameResult(History));
        }
    }
}
