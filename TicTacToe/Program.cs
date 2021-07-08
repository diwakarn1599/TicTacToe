using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Board;
            //object for playgame class
            PlayGame game = new PlayGame();
            Console.WriteLine("Tic Tac Toe Game");
            Board = game.InitializeBoard();
        }
    }
}
