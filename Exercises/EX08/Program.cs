using System;

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
            int select = 0;
            try
            {
                do
                {
                    select = int.Parse(Console.ReadLine());
                    if (select < 0 && select > 2)
                        Console.WriteLine("You must enter either 1 or 2.");
                } while (select < 0 && select > 2);
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter an intiger.");
                StartGame();
            }
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
            int topRange = 100;

            try
            {
                do
                {
                    topRange = int.Parse(Console.ReadLine());
                    if (topRange <= 0)
                    {
                        Console.WriteLine("You must enter a positive intiger.");
                        Console.Write("Enter the top number: ");
                    }
                } while (topRange <= 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter an intiger value.");
                ComputerGuess();
            }

            Console.Write($"Enter the number between 1 and {topRange} for the computer to guess: ");

            int guessThisNum = -1;

            try
            {
                do
                {
                    guessThisNum = int.Parse(Console.ReadLine());

                    if (guessThisNum <= 0)
                    {
                        Console.WriteLine("You must enter a positive intiger.");
                        Console.Write("Enter the top number: ");
                    }
                } while (guessThisNum <= 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter an intiger value.");
                ComputerGuess();
            }

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
            Console.Write("Enter the maximum number of the range you would like to guess from: ");
            int topRange = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number you will guess is between 1 and {topRange}");
            Console.Write("Enter your guess: ");
            Random random = new Random();
            int numToGuess = random.Next(1, topRange + 1);
            int timesGuessed = 1;
            int humanGuess;
            do
            {
                humanGuess = int.Parse(Console.ReadLine());
                if (humanGuess > numToGuess)
                {
                    Console.WriteLine("Your guess was too high.");
                    timesGuessed++;
                }
                else if (humanGuess < numToGuess)
                {
                    Console.WriteLine("Your guess was too low.");
                    timesGuessed++;
                }
                else if (humanGuess == numToGuess)
                {
                    Console.WriteLine($"The number was {numToGuess}. You guessed correctly!");
                    Console.WriteLine($"It took you {timesGuessed} times to guess the computers number.");

                }
            } while (humanGuess != numToGuess);
        }
    }
}