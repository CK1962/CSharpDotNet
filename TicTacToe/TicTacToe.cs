using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();

                switchplayer();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
            
        }

        private static void switchplayer()
        {
            if (playerTurn == "X")
            {
                playerTurn = "O";
            }
            else
            {
                playerTurn = "X";
            }
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());

            PlaceMark(row, column);
        }

        public static void PlaceMark(int row, int column)
        {
            board[row][column] = playerTurn;
        }

        public static bool CheckForWin()
        {
            if (HorizontalWin())
            {
                return true;
                
            }
            Console.WriteLine("You Win");

            if (VerticalWin())
            {
                return true;
            }
            Console.WriteLine("You Win");
            if (DiagonalWin())
            {
                return true;
            }
            Console.WriteLine("You Win");
            return false;
        }

        public static bool CheckForTie()
        {
            bool noWinner = !CheckForWin();

            bool allFilled = board[0][0] != " " &&
                board[0][1] != " " &&
                board[0][2] != " " &&
                board[1][0] != " " &&
                board[1][1] != " " &&
                board[1][2] != " " &&
                board[2][0] != " " &&
                board[2][1] != " " &&
                board[2][2] != " ";

            return noWinner && allFilled;
            Console.WriteLine("No Winner");
        }
        
        public static bool HorizontalWin()
        {
            if (board[0][0] == board[0][1] && board [0][1] == board[0][2] && board [0][0] != " ")
            {
                return true;
            }
            if (board[1][0] == board[1][1] && board[1][1] == board[1][2] && board[1][0] != " ")
            {
                return true;
            }
            if (board[2][0] == board[2][1] && board[2][1] == board[2][2] && board[2][0] != " ")
            {
                return true;
            }
            return false;
        }

        public static bool VerticalWin()
        {
            if (board[0][0] == board[1][0] && board[1][0] == board[2][0] && board[0][0] != " ")
            {
                return true;
            }
            if (board[0][1] == board[1][1] && board[1][1] == board[2][1] && board[0][1] != " ")
            {
                return true;
            }
            if (board[0][2] == board[1][2] && board[1][2] == board[2][2] && board[0][2] != " ")
            {
                return true;
            }

            return false;
        }

        public static bool DiagonalWin()
        {
            if (board[0][0] == board[1][1] && board[1][1] == board[2][2] && board[0][0] != " ")
            {
                return true;
            }
            if (board[0][2] == board[1][1] && board[1][1] == board[2][0] && board[0][2] != " ")
            {
                return true;
            }

            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
