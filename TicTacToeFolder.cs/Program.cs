using System;
namespace TicTacToeWorkshop
{
    public class TicTacToeGame
    {
        static void Main(string[] args)
        {
            char[] board = CreateTheBoard();
        }
        //UC1//
        public static char[] CreateTheBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i <= board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
	//UC3//
        public static void ShowBoard(char[] board)
        {
            Console.WriteLine("\n" + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("__________");
            Console.WriteLine("\n" + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("__________");
            Console.WriteLine("\n" + board[7] + " | " + board[8] + " | " + board[9]);
            Console.WriteLine("__________");
        }
    }
}
