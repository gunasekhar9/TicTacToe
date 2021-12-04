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
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
