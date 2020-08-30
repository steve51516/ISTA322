using System;
using System.Linq;

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
            BiSectionAlg.Search(guessThisNum, range, range.Length / 2);
        }
        void HumanGuess()
        {
            Random random = new Random();

            Console.Write("Enter the maximum number of the range you would like to guess from: ");
            int topRange = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number you will guess is between 1 and {topRange}");
            random.Next(1, topRange + 1);
        }

    }
}