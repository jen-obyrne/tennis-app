﻿using Xunit;
using Tennis.Services;

namespace Tests
{
    public class TennisTests
    {
        private readonly GameService _gameService;
        
        public TennisTests()
        {
            _gameService = new GameService();
        }
    
        [Fact]
        public void ReturnNoScoresIfNoScoresGiven() 
        {
            var scores = new string[0];
            var results = _gameService.PlayGame(scores);
            
            Assert.Equal(string.Empty, results);
        }

        [Fact]
        public void IncorrectFormattingReturnsErrorMessage()
        {
            var scores = new string[1]{"Life on Mars"};
            var results = _gameService.PlayGame(scores);

            const string expected = "Uh oh. I'm expecting a row of numbers! Not this nonsense";

            Assert.Equal(expected, results);
        }

        [Fact]
        public void ScoresReturnStringEquivalentIfScoresOnlyAgainstOnePlayer()
        {
            var scores = new string[2]{"1","1"};
            var results = _gameService.PlayGame(scores);

            const string expected = "Thirty, love";

            Assert.Equal(expected, results);
        }

        [Fact]
        public void ScoresReturnStringEquivalentBothPlayersHaveEqualPoints()
        {
            var scores = new string[4]{"1","1","2","2"};
            var results = _gameService.PlayGame(scores);

            const string expected = "Thirty all";

            Assert.Equal(expected, results);
        }
    }
}
