using System;
using System.Collections.Generic;

namespace UnitTestProject28
{
    public class Tennis
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        private int _secondPlayerScore;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            if (IsSameScore())
            {
                if (IsDeuce())
                {
                    return Deuce();
                }

                return SameScore();
            }
            else
            {
                if (IsGamePoint())
                {
                    if (IsAdv())
                    {
                        return AdvScore();
                    }
                    return AdvPlayer() + " Win";
                }
                return LookupScore();
            }
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private string SameScore()
        {
            return _scoreLookup[_firstPlayerScore] + " All";
        }

        private string AdvScore()
        {
            return $"{AdvPlayer()} Adv";
        }

        private bool IsGamePoint()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private string AdvPlayer()
        {
            var advPlayer = _firstPlayerScore > _secondPlayerScore
                ? _firstPlayerName
                : _secondPlayerName;
            return advPlayer;
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