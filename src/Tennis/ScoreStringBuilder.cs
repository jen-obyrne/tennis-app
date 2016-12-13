using System;

namespace ConsoleApplication
{
    public class ScoreStringBuilder
    {
        public string EqualScores(int score)
        {
            return Enum.GetName(typeof(TennisScore), score) + " all";
        }
    }
}
