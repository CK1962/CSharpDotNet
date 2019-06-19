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
                Symbol = "x";
            }
            else
            {
                int openCircleId = int.Parse("25CB", NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(openCircleId);
                Symbol = "o";
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

        public Checker GetChecker(Position pos)
        {
            foreach(Checker c in Checkers)
            {
                if(c.Position.Row == pos.Row &&
                    c.Position.Col == pos.Col)
                {
                    return c;
                }
            }

            return null;
        }

        public void RemoveChecker(Checker checker)
        {
            Checkers.Remove(checker);
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            checker.Position = dest;
        }

        public bool CheckForWin()
        {
            bool blackWon = true;
            bool whiteWon = true;
            
            foreach(Checker c in Checkers)
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
            // ...       

            return false;
        }

        public bool IsCapture(Position src, Position dest)
        {
            // ...

            return false;
        }

        public Checker GetCaptureChecker(Position src, Position dest)
        {
            // ..

            return null;
        }

        public Position ProcessInput()
        {
            // ...

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
                    Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
            }
        }
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

