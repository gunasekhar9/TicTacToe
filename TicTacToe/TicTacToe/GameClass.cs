﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class GameClass
    {
        char[] board = new char[10];
        public char[] Initial()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public char Playerchoosing()
        {
            Console.WriteLine("Choose the Charecters 'X' or 'O' for player or for computer to play the Tic Tac Toe Game ");
            char player = Convert.ToChar(Console.ReadLine());
            return player;
        }
        public void Display()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("__|_|__ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("__|_|__ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}
