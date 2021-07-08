using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class PlayGame
    {
        

        /// <summary>
        /// Method for initializing Board
        /// </summary>
        /// <returns></returns>
        public  char[] InitializeBoard()
        {
            char[] Board = new char[10];
            //Assigning empty spaces to board
            for (int i = 1; i < Board.Length; i++)
            {
                Board[i] = ' ';
            }
            Console.WriteLine("Initialized Board");
            return Board;
        }
        public static string GetPlayerInput()
        {
            Console.WriteLine("Enter Your Character X/O");
            string player = Console.ReadLine().ToUpper();

            if(player.Equals("X") || player.Equals("O"))
            {
                return player;
            }
            else
            {
                Console.WriteLine("Enter either X or O");
                return GetPlayerInput();
            }
            

        }
        public static string GetComputerValue( string playerValue)
        {
            string computerValue;
            computerValue = (playerValue == "X") ? "O" : "X";
            return computerValue;

        }
    }
}
