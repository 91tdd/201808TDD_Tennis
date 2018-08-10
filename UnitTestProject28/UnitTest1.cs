using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject28
{
    [TestClass]
    public class TennisTests
    {
        private Tennis _tennis = new Tennis();

        [TestMethod]
        public void love_all()
        {
            ScoreShouldBe(expected: "Love All");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}