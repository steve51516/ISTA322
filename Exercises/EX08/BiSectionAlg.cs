using System;
using System.Linq;

namespace EX08
{
    public class BiSectionAlg
    {
        public static void Search(int n, int[] range, int compGuess)
        {
            if (n > compGuess)
            {
                Console.WriteLine($"The computer guessed {compGuess}.");
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
                Search(n, range, compGuess);
            }
            else if (n < compGuess)
            {
                Console.WriteLine($"The computer guessed {compGuess}.");
                range = new int[range.Max() - compGuess];
                for (int i = 0; i < range.Length; i++)
                {
                    range[i] = (compGuess - range.Length) + i;
                }
                if (range.Length <= 2)
                    compGuess = range[0];
                else
                    compGuess = range.Min() + (range.Length / 2);
                Search(n, range, compGuess);
            }
            else
                Console.WriteLine($"The computer guessed your number! it's {compGuess}.");
        }
    }
}