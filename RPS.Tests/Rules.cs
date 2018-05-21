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
    }
}
