using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class GuessingGame
    {
        public void StartGame()
        {
            Console.WriteLine("1) Guess the computers number.");
            Console.WriteLine("2) Have the computer guess your number");
            Console.Write("Selection: ");
            int guess;
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Guess a number between 1 and 10");
                    guess = int.Parse(Console.ReadLine());
                    if (guess > 0 && guess < 11)
                        HumanGuess(guess);
                    break;
                case 2:
                    Console.WriteLine("The computer will guess your number.");
                    Console.Write("Enter a number between 1 and 10: ");
                    guess = int.Parse(Console.ReadLine());
                    if (guess > 0 && guess < 11)
                        ComputerGuess(guess);
                    else
                    {
                        Console.WriteLine("You must enter a number between 1 and 10");
                        StartGame();
                    }
                    break;
                default:
                    Console.WriteLine("You must enter a 1 or 2.");
                    StartGame();
                    break;
            }
        }
        void ComputerGuess(int n)
        {
            List<int> range = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int newN = bySectionSearch(n, range);
            if (n == newN)
                Console.WriteLine($"Your guess was {newN}");

        }
        void HumanGuess(int n)
        {
            int[] range = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        private int bySectionSearch(int n, List<int> range)
        {
            if (range.Count != 1)
            {
                if (n == range.Count / 2)
                    return n;
                if (n > range.Count / 2) // Removes first half of list if n is greater than half.
                {
                    for (int i = 0; i < range.Count / 2 ; i++)
                        range.RemoveAt(i);
                }
                if (n < range.Count / 2) // Removes last half of the list if n is less than half.
                {
                    for (int i = range.Count; i > n; i--)
                        range.RemoveAt(i);
                }
            }
            return range[0];
        }
    }
}