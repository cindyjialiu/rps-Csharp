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
        public void GameStatusIsPlayer1WonFrom2Moves()
        {
            var History = new List<wonDrawLost> { wonDrawLost.won, wonDrawLost.won };
            Assert.AreEqual(gameResult.player1Won, GameFinished.GameResult(History));
        }

        [TestMethod]
        public void GameStatusIsPlayer1WonFrom3Moves()
        {
            var History = new List<wonDrawLost> { wonDrawLost.lost, wonDrawLost.won, wonDrawLost.won };
            Assert.AreEqual(gameResult.player1Won, GameFinished.GameResult(History));
        }

        [TestMethod]
        public void GameStatusIsPlayer2WonFrom2Moves()
        {
            var History = new List<wonDrawLost> { wonDrawLost.lost, wonDrawLost.lost };
            Assert.AreEqual(gameResult.player2Won, GameFinished.GameResult(History));
        }

        [TestMethod]
        public void GameStatusIsNotFinished()
        {
            var History = new List<wonDrawLost> { wonDrawLost.lost };
            Assert.AreEqual(gameResult.notFinished, GameFinished.GameResult(History));
        }
    }
}
