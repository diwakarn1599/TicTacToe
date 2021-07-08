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

        //Method for getting player input
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
        public void ShowBoard(char[] Board)
        {
            for(int i = 1; i < Board.Length; i+=3)
            {
                Console.WriteLine($"{Board[i]}|{Board[i+1]}|{Board[i+2]}");
                if ((i + 2)!= Board.Length-1)
                {
                    Console.WriteLine("------");
                }
            }
        }
        public void GamePlay(char[] Board,string player,string computer)
        {
            Console.WriteLine("***********");
            while (CheckPlay(Board))
            {
                ShowBoard(Board);
                Console.WriteLine("Enter Position from 1-9");
                int position = Convert.ToInt32(Console.ReadLine());
                if (position <= 9)
                {
                    if (Board[position].Equals(' '))
                    {
                        Board[position] = Convert.ToChar(player);
                        
                    }
                    else
                    {
                        Console.WriteLine("This position is occupied...Enter another position");
                        GamePlay(Board, player, computer);
                    }
                }
                else
                {
                    Console.WriteLine("You have entered the wrong vlaue Enter the value B/w 1-9");
                    GamePlay(Board, player, computer);
                }
            }
            
        }

        public bool CheckPlay(char[] Board)
        {
            for(int i = 1; i < Board.Length; i++)
            {
                if(Board[i] ==' ')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
