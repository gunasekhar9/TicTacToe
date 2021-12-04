using System;
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
    }
}
