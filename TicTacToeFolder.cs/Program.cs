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
	private static char ChooseLetterFromUser()
        {
            Console.WriteLine("Choose between X and O to play the Tic Tac Toe Game");
            string userLetter = Console.ReadLine();
	    if (userLetter == "X")
            {
                return char.ToUpper(userLetter[0]);
            }
            else if (userLetter == "O")
            {
                return char.ToUpper(userLetter[0]);
            }
            else if (userLetter == "x")
            {
                return char.ToUpper(userLetter[0]);
            }
            else if (userLetter == "o")
            {
                return char.ToUpper(userLetter[0]);
            }
            else
            {
                Console.WriteLine("Enter valid input");
                userLetter = Console.ReadLine();
                return char.ToUpper(userLetter[0]);
            }
        }
    }
}
