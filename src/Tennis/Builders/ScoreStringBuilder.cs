using System;
using Tennis.Enums;

namespace Tennis.Builders
{
    public class ScoreStringBuilder
    {
        public string BuildEqualScore(int score)
        {
            return Enum.GetName(typeof(TennisScore), score) + " all";
        }
    }
}
