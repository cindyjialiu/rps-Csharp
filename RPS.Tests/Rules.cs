using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class RulesTest
    {
        [TestMethod]
        public void RockBeatsScissors()
        {
            Assert.AreEqual(wonDrawLost.draw, Rules.Beats("rock", "rock"));
        }
    }
}
