using System;
using Tennis.Services;

namespace Tennis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1 1 2 2 2 1 1 1
            //if you win after 40 you win game
            var _gameService = new GameService();
            var result = _gameService.PlayGame(args);
            Console.WriteLine(result);        
            Console.ReadLine();
        }
    }
}
