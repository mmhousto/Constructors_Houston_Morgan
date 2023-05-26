using System;

namespace Constructors_Houston_Morgan
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("CS:GO", "FPS");

            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            Game myOtherGame = new Game();

            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!");
        }
    }
}
