using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind2
{
    class Program
    {
        static int tryCount = 0;
        const int allowedAttempts = 4;
        const int codelength = 2;
        static string[] secret = new string[codelength];
        static string[] colorArray = new string[] { "red", "yellow", "blue" };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mastermind!");

            // pick secret answer
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                secret[i] = colorArray[rnd.Next(3)];
                //secret[0] = "red";
                //secret[1] = "blue";
            }

            bool isGameOver = false;

            // give user chances to guess
            do
            {
                tryCount++;

                try
                {
                    Console.Write("Enter your guess: (red, yellow, blue): ");
                    string firstColor = Console.ReadLine().ToLower();
                    string secondColor = Console.ReadLine().ToLower();
                    //Console.WriteLine();

                    // check input
                    isGameOver = IsSolved(firstColor, secondColor);

                    // check hints
                    if (!isGameOver)
                    {
                        CheckHints(firstColor, secondColor);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input; please try again.");
                    Console.WriteLine();
                }
            } while (tryCount < allowedAttempts && !isGameOver);

            Console.ReadLine();
        }

        static bool IsSolved(string firstColor, string secondColor)
        {
            if (secret[0] == firstColor && secret[1] == secondColor)
            {
                Console.WriteLine("You Won!!");
                return true;
            }

            return false;
        }

        static void CheckHints(string firstColor, string secondColor)
        {
            int numberOfColorsFound = NumberOfColorsFound(firstColor, secondColor);
            int numberOfColorsCorrectPosition = NumberOfColorsCorrectPosition(firstColor, secondColor);

            Console.WriteLine(numberOfColorsFound + "-" + numberOfColorsCorrectPosition);
        }

        static int NumberOfColorsFound(string firstColor, string secondColor)
        {
            bool firstColorFound = secret.Contains(firstColor);
            bool secondColorFound = secret.Contains(secondColor);

            if (firstColorFound && !secondColorFound)
            {
                return 1;
            }
            else if (!firstColorFound && secondColorFound)
            {
                return 1;
            }
            else if (firstColorFound && secondColorFound)
            {
                return 2;
            }

            return 0;
        }

        static int NumberOfColorsCorrectPosition(string firstColor, string secondColor)
        {
            //bool firstColorCorrectPosition = secret[0] == firstColor;

            bool firstColorCorrectPosition = false;
            if (secret[0] == firstColor)
            {
                firstColorCorrectPosition = true;
            }

            bool secondColorCorrectPosition = false;
            if (secret[1] == secondColor)
            {
                secondColorCorrectPosition = true;
            }

            if (firstColorCorrectPosition && !secondColorCorrectPosition)
            {
                return 1;
            }
            else if (!firstColorCorrectPosition && secondColorCorrectPosition)
            {
                return 1;
            }

            return 0;
        }

    }
}