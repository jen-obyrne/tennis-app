using System;
using Xunit;
using ConsoleApplication;

namespace Tests
{
    public class TennisTests
    {
        private readonly Game _game;
        
        public TennisTests()
        {
            _game = new Game();
        }
    
        [Fact]
        public void ReturnNoScoresIfNoScoresGiven() 
        {
            var scores = new string[0];
            var results = _game.TrackScores(scores);
            
            Assert.Equal(string.Empty, results);
        }

        [Fact]
        public void IncorrectFormattingReturnsErrorMessage()
        {
            var scores = new string[1]{"Life on Mars"};
            var results = _game.TrackScores(scores);

            const string expected = "Uh oh. I'm expecting a row of numbers! Not this nonsense";

            Assert.Equal(expected, results);
        }

        [Fact]
        public void ScoresReturnStringEquivalentIfScoresOnlyAgainstOnePlayer()
        {
            var scores = new string[2]{"1","1"};
            var results = _game.TrackScores(scores);

            const string expected = "Thirty, love";

            Assert.Equal(expected, results);
        }

        [Fact]
        public void ScoresReturnStringEquivalentBothPlayersHaveEqualPoints()
        {
            var scores = new string[4]{"1","1","2","2"};
            var results = _game.TrackScores(scores);

            const string expected = "Thirty all";

            Assert.Equal(expected, results);
        }
    }
}
