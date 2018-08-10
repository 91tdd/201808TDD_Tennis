using System.Collections.Generic;

namespace UnitTestProject28
{
    public class Tennis
    {
        private readonly string _firstPlayerName;
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScore;

        public Tennis(string firstPlayerName)
        {
            _firstPlayerName = firstPlayerName;
        }

        public string Score()
        {
            if (IsSameScore())
            {
                if (_firstPlayerScore >= 3)
                {
                    return Deuce();
                }
                return _scoreLookup[_firstPlayerScore] + " All";
            }
            else
            {
                if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
                {
                    if (_firstPlayerScore - _secondPlayerScore == 1)
                    {
                        return $"{_firstPlayerName} Adv";
                    }
                }
                return LookupScore();
            }
        }

        private static string Deuce()
        {
            return "Deuce";
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