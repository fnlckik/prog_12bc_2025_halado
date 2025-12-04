using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("chars.txt");
            game.ListEnemies();
            game.Simulate();
        }
    }
}
