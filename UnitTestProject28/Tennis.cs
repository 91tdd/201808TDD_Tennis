using System.Collections.Generic;

namespace UnitTestProject28
{
    public class Tennis
    {
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScore;

        public string Score()
        {
            if (_secondPlayerScore == 2)
            {
                return "Love Thirty";
            }
            if (_secondPlayerScore == 1)
            {
                return "Love Fifteen";
            }
            if (_firstPlayerScore > 0)
            {
                return _scoreLookup[_firstPlayerScore] + " Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}