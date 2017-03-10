using System;
using Tennis.Builders;

namespace Tennis.Services
{
    public class GameService
    {
        private readonly ScoreStringBuilder _scoreBuilder;
        public GameService()
        {
            _scoreBuilder = new ScoreStringBuilder();
        }

        public string PlayGame(string[] scores)
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
                return CalculateFinalScores(playerOneScore, playerTwoScore);
            }
            else
            {
                var score = playerOneScore;
                return _scoreBuilder.BuildEqualScore(score);
            }
            
            throw new NotImplementedException("Please create a test first");
        }

        private string CalculateFinalScores(int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore == 1)
            {
                return "Fifteen, love";
            }
            if (playerTwoScore == 2)
            {
                return "Thirty, love";
            }

            return "ermegerd";
        }
    }
}