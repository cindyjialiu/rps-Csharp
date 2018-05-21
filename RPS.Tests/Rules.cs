using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class RulesTest
    {
        [TestMethod]
        public void RockDrawsRock()
        {
            Assert.AreEqual(wonDrawLost.draw, Rules.Beats(moves.rock, moves.rock));
        }

        [TestMethod]
        public void RockBeatsScissors()
        {
            Assert.AreEqual(wonDrawLost.won, Rules.Beats(moves.rock, moves.scissors));
        }

        [TestMethod]
        public void ScissorsBeatsPaper()
        {
            Assert.AreEqual(wonDrawLost.won, Rules.Beats(moves.scissors, moves.paper));
        }

        [TestMethod]
        public void ScissorsBeatsRock()
        {
            Assert.AreEqual(wonDrawLost.lost, Rules.Beats(moves.scissors, moves.rock));
        }
    }
}
