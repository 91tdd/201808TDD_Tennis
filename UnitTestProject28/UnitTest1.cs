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

        [TestMethod]
        public void fifteen_love()
        {
            _tennis.FirstPlayerScore();
            ScoreShouldBe(expected: "Fifteen Love");
        }

        [TestMethod]
        public void thirty_love()
        {
            _tennis.FirstPlayerScore();
            _tennis.FirstPlayerScore();
            ScoreShouldBe(expected: "Thirty Love");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}