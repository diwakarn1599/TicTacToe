using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Board;
            char playerValue, computerValue;
            //object for playgame class
            PlayGame game = new PlayGame();
            Console.WriteLine("Tic Tac Toe Game");
            Board = game.InitializeBoard();
            playerValue = PlayGame.GetPlayerInput();
            computerValue = PlayGame.GetComputerValue(playerValue);


        }
    }
}
