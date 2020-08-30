using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EX08
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessingGame game = new GuessingGame();

            game.StartGame();
        }
    }
    class GuessingGame
    {
        public void StartGame()
        {
            Console.WriteLine("1) Guess the computers number.");
            Console.WriteLine("2) Have the computer guess your number");
            Console.Write("Selection: ");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    HumanGuess();
                    break;
                case 2:
                    ComputerGuess();
                    break;
                default:
                    Console.WriteLine("You must enter a 1 or 2.");
                    StartGame();
                    break;
            }
        }
        void ComputerGuess()
        {
            Console.WriteLine("The computer will guess your number.");
            Console.WriteLine("The number will be between 1 and your selected input. Pick the maximum possible number.");
            Console.Write("Enter the top number: ");
            int topRange = int.Parse(Console.ReadLine());
            Console.Write($"Enter the number between 1 and {topRange} for the computer to guess: ");
            int guessThisNum = int.Parse(Console.ReadLine());
                int[] range = new int[topRange];
                for (int i = 0, j = 1; i < range.Length; i++)
            {
                range[i] = j;
                j++;
            }
            biSectionSearch(guessThisNum, range, range.Length / 2);
        }
        void HumanGuess()
        {
            //int[] range = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Guess a number between 1 and 10");
            //int guess = int.Parse(Console.ReadLine());
            //if (guess > 0 && guess < 10)
            //else
            //    Console.WriteLine("You must enter a number between 1 and 10.");
        }

        private void biSectionSearch(int n, int[] range, int compGuess)
        {
            if (n == compGuess)
                Console.WriteLine($"The computer guessed your number! it's {compGuess}.");

            if (n > compGuess)
            {
                Console.WriteLine($"The computer guessed {compGuess}. This was incorrect, trying agian.");

                range = new int[range.Max() - compGuess];
                for (int i = 0, j = compGuess + 1; i < range.Length; i++)
                {
                    range[i] = j;
                    j++;
                }
                if (range.Length <= 2)
                    compGuess = range[0];
                else
                    compGuess = range.Min() + (range.Length / 2);
                biSectionSearch(n, range, compGuess);
            }
            if (n < compGuess)
            {
                Console.WriteLine($"The computer guessed {compGuess}. This was incorrect, trying agian.");

                range = new int[range.Max() - compGuess];
                for (int i = 0; i < range.Length; i++)
                {
                    range[i] = (compGuess - range.Length) + i;
                }
                if (range.Length <= 2)
                    compGuess = range[0];
                else
                    compGuess = range.Min() + (range.Length / 2);
                biSectionSearch(n, range, compGuess);
            }
        }
    }
}