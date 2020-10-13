using System;
namespace TicTacToeWorkshop
{
    public class TicTacToeGame
    {   public const int HEAD = 0;
        public const int TAIL = 0;
        public enum Player
        {
            USER,
            COMPUTER
        };
        static void Main(string[] args)
        {
            char[] board = CreateTheBoard();
	    char userLetter = ChooseLetterFromUser();
            ShowBoard(board);
            int userMove = GetUserMove(board);
	    MakeMove(board, userMove, userLetter);
	    Player player = GetWhoStartsFirst();
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
	//UC2//
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
	//UC4//
        public static int GetUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while( true)
            {
                Console.WriteLine("Enter your next move between 1 to 9: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if((input>= 1 || input <= 9) && isSpaceFree(board, input))
                 {
                      return input;
                 }
                else 
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
        private static bool isSpaceFree(char[] board, int input)
        {
            return board [input] == ' ';
        }
        //UC5//
        private static void MakeMove(char[] board, int input, char inputLetter)
        {
            bool spaceFree = isSpaceFree(board, input);
            if(spaceFree)
            {
                Console.WriteLine("The space is free");
                board[input] = inputLetter;
            }
            else
            {
                Console.WriteLine("The space is not free");
            }
        }
	 //UC6//
        private static Player GetWhoStartsFirst()
        {
            int toss = GetRandomChoice(2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;
        }
        private static int GetRandomChoice(int choices)
        {
            Random random = new Random();
            return (int)(random.Next()*10)% choices;
        }
    }
}
