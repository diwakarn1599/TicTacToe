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
        
    }
}
