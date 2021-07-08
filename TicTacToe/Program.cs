using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //object for playgame class
            PlayGame game = new PlayGame();
            Console.WriteLine("Tic Tac Toe Game");
            game.InitializeBoard();
            
        }
    }
}
