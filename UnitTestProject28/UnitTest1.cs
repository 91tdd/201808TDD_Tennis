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

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldBe(expected: "Love Thirty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennis.FirstPlayerScore();
            _tennis.SecondPlayerScore();
            ScoreShouldBe(expected: "Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScoreTimes(times: 2);
            GivenSecondPlayerScoreTimes(times: 2);

            ScoreShouldBe(expected: "Thirty All");
        }

        private void GivenSecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.SecondPlayerScore();
            }
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