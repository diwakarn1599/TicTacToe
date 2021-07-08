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
            string player = Console.ReadLine();
            return player;

        }
        public static string GetComputerValue( string playerValue)
        {
            string computerValue;
            if(playerValue.ToLower() =="x")
            {
                computerValue = "O";
            }
            else
            {
                computerValue = "X";
            }
            return computerValue;

        }
    }
}
