using Xunit;
using Tennis.Builders;

namespace Tests
{
    public class ScoreStringBuilderTests
    {
        private readonly ScoreStringBuilder _scoreStringBuilder;

        public ScoreStringBuilderTests()
        {
            _scoreStringBuilder = new ScoreStringBuilder();
        }

        [Fact]
        public void EqualScoresReturnCorrectString()
        {
            const int scores = 2;
            const string expected = "Thirty all";

            var result = _scoreStringBuilder.BuildEqualScore(scores);

            Assert.Equal(expected, result);
        }
    }
}