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
            var args = new string[0];
            var scores = _game.TrackScores(args);
            
            Assert.Equal(string.Empty, scores);
        }
    }
}
