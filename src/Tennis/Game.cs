using System;

namespace ConsoleApplication
{
    public class Game
    {
        private readonly ScoreStringBuilder _scoreStringBuilder;
        public Game()
        {
            _scoreStringBuilder = new ScoreStringBuilder();
        }

        public string TrackScores(string[] scores)
        {
            if (scores.Length == 0)
            {
                return string.Empty;
            }

            var playerOneScore = 0;
            var playerTwoScore = 0;

            foreach(var score in scores)
            {
                int point;
                var parsedSuccessfully = int.TryParse(score, out point);

                if (!parsedSuccessfully)
                {
                    return "Uh oh. I'm expecting a row of numbers! Not this nonsense";
                }

                if (point == 1)
                {
                    playerOneScore = playerOneScore + 1;
                }
                else if (point == 2)
                {
                    playerTwoScore = playerTwoScore + 1;
                }
            }

            if (playerOneScore != playerTwoScore)
            {
                if (playerOneScore == 1)
                {
                    return "Fifteen, love";
                }
                if (playerOneScore == 2)
                {
                    return "Thirty, love";
                }
            } 
            else
            {
                var score = playerOneScore;
                return _scoreStringBuilder.EqualScores(score);
            }

            
            throw new NotImplementedException("Please create a test first");
        }
    }
}