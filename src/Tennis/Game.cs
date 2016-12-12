using System;

namespace ConsoleApplication
{
    public class Game
    {
        public string TrackScores(string[] scores)
        {
            if (scores.Length == 0)
            {
                return string.Empty;
            }

            var playerOneScore = 0;

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
                    playerOneScore =+ 1;
                }
            }

            if (playerOneScore == 1)
            {
                return "Fifteen - love, to player one";
            }
            if (playerOneScore == 2)
            {
                return "Thirty - love, to player one";
            }
            throw new NotImplementedException("Please create a test first");
        }
    }
}