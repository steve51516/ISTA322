using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07
{
    class Roulette
    {
        public static (int[], string[]) CreateWheel()
        {

            // Creates American standard wheel.
            int[] numBin = { 0, 2, 14, 35, 23, 4, 16, 33, 21, 6, 18, 31, 19, 8, 12, 29, 25, 10, 27, 00, 1, 13, 36, 24, 3, 15, 34, 22, 5, 17, 32, 20, 7, 11, 30, 26, 9, 28 };
            string[] colorBin = new string[38];

            int x, y, z = 0;
            Random random = new Random();
            string[] randomColors = { "black", "red" };
            while (z < 38)
            {
                x = random.Next(0, 38);
                y = random.Next(0, 2);
                if (colorBin[x] == null)
                {
                    colorBin[x] = randomColors[y];
                    z++;
                }
            }

            colorBin[0] = "green";
            colorBin[19] = "green";

            Console.WriteLine("Below is the Roulette board's numbers and colors.");
            for (int i = 0; i <= numBin.Length - 1; i++)
            {
                Console.WriteLine($"Bin: {numBin[i]} Color: {colorBin[i]}");
            }

            return (numBin, colorBin);
        }
        private static int[] createMat()
        {
            int[] mat = new int[36];
            for (int i = 0; i < mat.Length; i++)
            {
                mat[i] = i;
            }
            return mat;
        }
        private static int ballDrop()
        {
            Random random = new Random();
            return random.Next(39);
        }
        private static void binBet(int bet)
        {
            int winningBin = ballDrop();
            Console.WriteLine($"The winning bin number is: {winningBin}");
            Console.WriteLine($"Your bet was: {bet}");
            if (bet == winningBin)
                Console.WriteLine("YOU WON!!! Please collect your winnings of 35x1 now!!!");
            else
                Console.WriteLine("Sorry you lost. Please play again.");
        }
        private static void OddEvenBet(int selection)
        {
            var wheel = CreateWheel();
            int winningBin = ballDrop();
            if (selection == 2)
                if (winningBin % 2 == 0)
                    Console.WriteLine($"The winningBin is {winningBin}! Even bets won! Please collect your winnings of 1x1 now!");
                else
                    Console.WriteLine($"The winningBin is {winningBin}. You lost. Please play again.");
            if (selection == 1)
                if (winningBin % 2 != 0)
                    Console.WriteLine($"The winning bin is {winningBin} Odd bets won! Please collect your winnings of 1x1 now!");
                else
                    Console.WriteLine($"The winningBin is {winningBin}. You lost. Please play again.");
        }
        private static void colorsBet(string colorSelection)
        {
            var wheel = CreateWheel();
            int winningBin = ballDrop();
            if (wheel.Item2[winningBin] == colorSelection)
                Console.WriteLine($"{wheel.Item2[winningBin]} won! Please collect your winnings of 1x1 now!");
            else
                Console.WriteLine($"{wheel.Item2[winningBin]} won. You did not win. Please play again.");
        }
        private static void lowsHighsBet(int range)
        {
            var wheel = CreateWheel();
            int winningBin = ballDrop();
            if (range == 1)
            {
                if (winningBin <= 18)
                    Console.WriteLine($"The winning bin is {winningBin}! You won. Please collect your winnings of 1x1 now!");
                else
                    Console.WriteLine($"The winning bin is {winningBin}. You lost. Please play again.");
            }
            if (range == 2)
            {
                if (winningBin <= 38 && winningBin <= 19)
                    Console.WriteLine($"The winning bin is {winningBin}! You won. Please collect your winnings of 1x1 now!");
                else
                    Console.WriteLine($"The winning bin is {winningBin}. You lost. Please play again.");
            }
        }
        private static void dozensBet(int dozen)
        {
            var wheel = CreateWheel();
            int winningBin = ballDrop();
            if (dozen == 1)
            {
                if (winningBin >= 1 && winningBin <= 18)
                    Console.WriteLine($"The winning bin is {winningBin}! You won! Please collect your winnings of 2x1 now!");
                else
                    Console.WriteLine($"The winning bin is {winningBin}. That's outside of (1 - 18) You lost. Please play again.");
            }
            if (dozen == 2)
            {
                if (winningBin >= 13 && winningBin <= 24)
                    Console.WriteLine($"The winning bin is {winningBin}! You won! Please collect your winnings of 2x1 now!");
                else
                    Console.WriteLine($"The winning bin is {winningBin}. That's outside of (1 - 18) You lost. Please play again.");
            }
            if (dozen == 3)
            {
                if (winningBin >= 25 && winningBin <= 36)
                    Console.WriteLine($"The winning bin is {winningBin}! You won! Please collect your winnings of 2x1 now!");
                else
                    Console.WriteLine($"The winning bin is {winningBin}. That's outside of (1 - 18) You lost. Please play again.");
            }

        }
        private static void columnsBet(int column)
        {
            CreateWheel();
            Console.WriteLine($"\nYou chose column {column}. Good luck!");
            //var mat = createMat();
            int winningBin = ballDrop();
            //List<int> firsts = new List<int>();
            int[] firsts = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] seconds = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] thirds = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            bool result = false;
            if (column == 1)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (firsts[i] == winningBin)
                        result = true;
                }
            }
            if (column == 2)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (seconds[i] == winningBin)
                        result = true;
                }
            }
            if (column == 3)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (thirds[i] == winningBin)
                        result = true;
                }
            }
            if (result == true)
                Console.WriteLine($"\nThe winning bin is {winningBin}! You won! Please collect your winnings of 2x1 now!");
            else
                Console.WriteLine($"\nThe winning bin is {winningBin}. That's in another column. Please play again.");
        }
        public static int Menu()
        {
            Console.WriteLine("\n1: Bet on a bin number. Winnings are 35x1");
            Console.WriteLine("2: Bet on odds or even numbers.");
            Console.WriteLine("3: Bet on red or black colored numbers.");
            Console.WriteLine("4: Lows/Highs: low (1 - 18) or high (19 - 38) numbers.");
            Console.WriteLine("5: Dozens: row thirds, 1 - 12, 13 - 24, 25 - 36 ");
            Console.WriteLine("6. Columns: First, second, or third columns");
            Console.WriteLine("7: Street: rows, e.g., 1/2/3 or 22/23/24");
            Console.WriteLine("8: Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26");
            Console.WriteLine("9: Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36");
            Console.WriteLine("10: Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
            int x, selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Enter the bin number you want to bet on: ");
                    x = int.Parse(Console.ReadLine());
                    if (x > 0 && x <= 38)
                    {
                        CreateWheel();
                        binBet(x);
                    }
                    else
                    {
                        Console.WriteLine("You must enter a valid bin number. Reference the table information at the top of the console.");
                        Menu();
                    }
                    break;
                case 2:
                    Console.WriteLine("1: for odds");
                    Console.WriteLine("2: for evens");
                    x = int.Parse(Console.ReadLine());
                    if (x > 0 && x < 3)
                        OddEvenBet(x);
                    else
                    {
                        Console.WriteLine("You must enter 1 or 2 for odds or evens. Try again.");
                        Menu();
                    }
                    break;
                case 3:
                    Console.WriteLine("1: for reds");
                    Console.WriteLine("2: for blacks");
                    Console.Write("Enter selection: ");
                    x = int.Parse(Console.ReadLine());
                    if (x > 0 && x < 3)
                    {
                        if (x == 1)
                            colorsBet("red");
                        if (x == 2)
                            colorsBet("black");
                    }
                    else
                    {
                        Console.WriteLine("You must enter 1 or 2 for reds or blacks. Try again.");
                        Menu();
                    }
                    break;
                case 4:
                    Console.WriteLine("1: for lows (1 - 18)");
                    Console.WriteLine("2: for highs (19 - 38)");
                    Console.Write("Enter selection: ");
                    x = int.Parse(Console.ReadLine());
                    if (x > 0 && x < 3)
                    {
                        lowsHighsBet(x);
                    }
                    else
                    {
                        Console.WriteLine("You must enter 1 or 2 for lows or highs. Try again.");
                        Menu();
                    }
                    break;
                case 5:
                    Console.WriteLine("1: 1 - 12");
                    Console.WriteLine("2: 13 - 24");
                    Console.WriteLine("3: 25 - 36");
                    Console.Write("Select a dozen: ");
                    x = int.Parse(Console.ReadLine());
                    if (x >= 1 && x <= 3)
                        dozensBet(x);
                    else
                    {
                        Console.WriteLine("You must enter 1, 2, or 3 to select a dozen. Try again.");
                        Menu();
                    }
                    break;
                case 6:
                    Console.WriteLine("1: First");
                    Console.WriteLine("2: Second");
                    Console.WriteLine("3: Third");
                    Console.Write("Select a column: ");
                    x = int.Parse(Console.ReadLine());
                    columnsBet(x);
                    break;
                //case 7:
                //case 8:
                //case 9:
                //case 10:
                default:
                    Console.WriteLine("Enter a selection between 1 and 10.");
                    Menu();
                    return 0;
            }
            return 0;
        }
    }
}
