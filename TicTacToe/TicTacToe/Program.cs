using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GameClass game = new GameClass();
            char[] board = game.Initial();
        }
    }
}
