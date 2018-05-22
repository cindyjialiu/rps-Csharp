using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class GameFinishedTests
    {
        [TestMethod]
        public void GameStatusIsDraw()
        {
            var History = new List<wonDrawLost> { wonDrawLost.draw, wonDrawLost.draw };
            Assert.AreEqual(gameResult.draw, GameFinished.GameResult(History));
        }

        [TestMethod]
        public void GameStatusIsPlayer1Won()
        {
            var History = new List<wonDrawLost> { wonDrawLost.won, wonDrawLost.won };
            Assert.AreEqual(gameResult.play1Won, GameFinished.GameResult(History));
        }
    }
}
