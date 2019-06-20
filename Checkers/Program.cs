using System;
using System.Collections.Generic;
using System.Globalization;

namespace Checkers
{
    public struct Position
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }


    public enum Color { White, Black }

    public class Checker
    {
        public string Symbol { get; private set; }
        public Color Team { get; private set; }
        public Position Position { get; set; }

        public Checker(Color team, int row, int col)
        {
            Team = team;
            Position = new Position(row, col);

            if (team == Color.Black)
            {
                int closedCircleId = int.Parse("25CF", NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(closedCircleId);
                Symbol = "X";
            }
            else
            {
                int openCircleId = int.Parse("25CB", NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(openCircleId);
                Symbol = "O";
            }
        }

    }

    public class Board
    {
        public List<Checker> Checkers { get; private set; }

        public Board()
        {
            Checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    Checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                    Checkers.Add(c);
                }
            }
        }

        public Checker GetChecker(Position src)
        {
            foreach (Checker c in Checkers)
            {
                if (c.Position.Row == src.Row &&
                    c.Position.Col == src.Col)
                {
                    return c;
                }
            }

            return null;
        }

        public void RemoveChecker(Checker checker)
        {
            if (Checker 1= null);
                {
                Checkers.Remove(checker);
            }
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            Checker c= new Checker(checker.Team, dest.Row, dest.Col)
            { 
            Checkers.Add(c);
            RemoveChecker(checker);
        }

        public bool CheckForWin()
        {
            bool blackWon = true;
            bool whiteWon = true;

            foreach (Checker c in Checkers)
            {
                if (c.Team == Color.White)
                {
                    blackWon = false;
                }
                else // c.Team == Color.Black
                {
                    whiteWon = false;
                }
            }

            return blackWon || whiteWon;
        }
    }

    public class Game
    {
        private readonly Board board;

        public Game()
        {
            this.board = new Board();
        }

        public void Start()
        {
            bool continueGame = true;

            DrawBoard();

            do
            {
                ProcessInput();
                DrawBoard();
                continueGame = !board.CheckForWin();

            }
            while (continueGame == true);
        }

        public bool IsLegalMove(Color player, Position src, Position dest)
        {
            //Rule one
            if (src.Row < 0 || src.Row > 7 || src.Col < 0 || src.Col > 7
                || dest.Row < 0 || dest.Row > 7 || dest.Col < 0
                || dest.Col > 7) return false;

            //Rule two
            int rowDistance = Math.Abs(dest.Row - src.Row);
            int colDistance = Math.Abs(dest.Col - src.Col);

            if (colDistance == 0 || rowDistance == 0) return false;
            if (rowDistance / colDistance != 1) return false;

            //Rule three
            if (rowDistance > 2) return false;

            //Rule four
            Checker c = board.GetChecker(src);
            if (c == null)
            {
                return false;
            }
            c = board.GetChecker(dest);
            if (c != null)
            {
                return false;
            }


            //Rule five
            if (rowDistance ==2)
            { 
                if (IsCapture(player, src, dest))
                {
                return true;
                }
                else
                {
                return false;
                }       
                else
                {
                return true;
                }  
            }       
        }
    public bool IsCapture(Color player, Position src, Position dest)
        {
            int rowDistance = Math.Abs(dest.Row - src.Row);
            int colDistance = Math.Abs(dest.Col - src.Col);
            if (rowDistance == 2 && colDistance ==2)
            {
                int row_mid = (dest.Row + src.Row) / 2;
                int col_mid = (dest.Col + src.Col) / 2;
                Position p = new Position(row_mid, col_mid);
                c = board.GetChecker(p);
                if (c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team == player)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public Checker GetCaptureChecker(Color player, Position src, Position dest)
        {
            if (IsCapture(player, src, dest))
            {
                int row_mid = (dest.Row + src.Row) / 2;
                int col_mid = (dest.Col + src.Col) / 2;
                Position p = new Postition(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                return c;
            }

            return null;
        }

        public Position ProcessInput()
        {
            Console.WriteLine

            return new Position();
        }

        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++) 
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.Checkers)
            {
                grid[c.Position.Row][c.Position.Col] = c.Symbol;
            }

            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write($" , {grid[r][c]}) \u2503");
                }
                Console.WriteLine();
                Console.Write(" ");
                for (int i = 0; i < 32; i++) ;
            }
            Console.Write("\u2501");
        }
        Console.WriteLine();
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Game game = new Game();
            game.Start();

            Console.ReadKey();
        }
    }
}

