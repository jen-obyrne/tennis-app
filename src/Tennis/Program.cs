using System;

namespace ConsoleApplication
{
    public class Program
    {
        private readonly Game _game;
        
        public static void Main(string[] args)
        {
            //1 1 2 2 2 1 1 1
            //if you win after 40 you win game
            var _game = new Game();
            var result = _game.TrackScores(args);
            Console.WriteLine(result);        
            Console.ReadLine();
        }
    }
}
