using System.Collections.Generic;

namespace UnitTestProject28
{
    public class Tennis
    {
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScore;

        public string Score()
        {
            if (IsSameScore())
            {
                if (_firstPlayerScore == 3)
                {
                    return "Deuce";
                }
                return _scoreLookup[_firstPlayerScore] + " All";
            }

            return LookupScore();
        }

        private string LookupScore()
        {
            return _scoreLookup[_firstPlayerScore] + " " + _scoreLookup[_secondPlayerScore];
        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
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