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
            GivenFirstPlayerScoreTimes(times: 2);
            ScoreShouldBe(expected: "Thirty Love");
        }

        [TestMethod]
        public void Forty_love()
        {
            GivenFirstPlayerScoreTimes(times: 3);
            ScoreShouldBe(expected: "Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennis.SecondPlayerScore();
            ScoreShouldBe(expected: "Love Fifteen");
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}