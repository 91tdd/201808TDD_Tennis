namespace UnitTestProject28
{
    public class Tennis
    {
        private int _firstPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore == 2)
            {
                return "Thirty Love";
            }
            if (_firstPlayerScore == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}