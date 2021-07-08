using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class PlayGame
    {
        char[] Board = new char[10];

        public void InitializeBoard()
        {
            //Assigning empty spaces to board
            for (int i = 1; i < 10; i++)
            {
                Board[i] = ' ';
            }
            Console.WriteLine("Initialized Board");
        }
    }
}
