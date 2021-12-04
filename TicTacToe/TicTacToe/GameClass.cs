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
        public void Display()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("     |     |     ");
        }
    }
    public void Position(char[] board, char player)
    {
        while (true)
        {
            Console.WriteLine("Enter position from 1 to 9:");
            int pos = Convert.ToInt32(Console.ReadLine());
            if (board[pos] == ' ')
            {
                board[pos] = player;
                break;
            }
            else
            {
                Console.WriteLine("Position already Occupied");
            }
        }
    }
