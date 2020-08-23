using System;

namespace EX07
{
    class Roulette
    {
        
        public static void BinBet(int winBin)
        {
            // Bet on a single bin
            Console.WriteLine($"The ball landed in {winBin}");
            Console.WriteLine($"Bin {winBin} won!!!");
        }
        public static void OddEvenBet(int winBin)
        {
            // Bet on odd or even numbers
            if (winBin % 2 == 0)
                Console.WriteLine("Odd numbers won.");
            else
                Console.WriteLine("Even numbers won.");
        }
        public static void ColorsBet(string[] colorBin, int winBin)
        {
            //Bet on reds, blacks, or greens
            if (colorBin[winBin] == "red")
                Console.WriteLine("reds won.");
            if (colorBin[winBin] == "black")
                Console.WriteLine("blacks won.");
            if (colorBin[winBin] == "green")
                Console.WriteLine("green won.");
        }
        public static void LowsHighsBet(int winBin)
        {
            //low (1 - 18) or high (19 - 38)
            if (winBin >= 1 && winBin <= 18)
                Console.WriteLine("Lows won.");
            else
                Console.WriteLine("Highs won.");
        }
        public static void DozensBet(int winBin)
        {
            // row thirds, 1 - 12, 13 - 24, 25 - 36
            if (winBin >= 1 & winBin <=12)
                Console.WriteLine("First dozen won.");
            if (winBin >= 13 & winBin <= 24)
                Console.WriteLine("Second dozen won.");
            if (winBin >=25 & winBin <=36)
                Console.WriteLine("Second dozen won.");
        }
        public static void ColumnsBet(int winBin)
        {
            // Bet on columns Firsts, Seconds, or Thirds
            if (winBin % 3 == 1)
                Console.WriteLine($"First column won.");
            if (winBin % 3 == 2)
                Console.WriteLine($"Second column won.");
            if (winBin % 3 == 0)
                Console.WriteLine($"Third column won.");
        }
        public static void StreetBet(int winBin)
        {
            // Bet on a street
            if (winBin >= 1 && winBin <= 3)
                    Console.WriteLine("First street won.");
            if (winBin >= 4 && winBin <= 6)
                Console.WriteLine("First street won.");
            if (winBin >= 7 && winBin <= 9)
                Console.WriteLine("First street won.");
            if (winBin >= 10 && winBin <= 13)
                Console.WriteLine("First street won.");
            if (winBin >= 14 && winBin <= 17)
                Console.WriteLine("First street won.");
            if (winBin >= 20 && winBin <= 23)
                Console.WriteLine("First street won.");
            if (winBin >= 26 && winBin <= 29)
                Console.WriteLine("First street won.");
            if (winBin >= 30 && winBin <= 33)
                Console.WriteLine("First street won.");
            if (winBin >= 34 && winBin <= 36)
                Console.WriteLine("First street won.");
        }
        public static void SixBet(int winBin)
        {
            // Bet on 6 numbers, or double rows
            if (winBin >= 1 && winBin <= 6)
                Console.WriteLine("First two rows won");
            if (winBin >= 7 && winBin <= 12)
                Console.WriteLine("Second two rows won");
            if (winBin >= 13 && winBin <= 18)
                Console.WriteLine("Third two rows won");
            if (winBin >= 19 && winBin <= 24)
                Console.WriteLine("Fourth two rows won");
            if (winBin >= 25 && winBin <= 30)
                Console.WriteLine("Fifth two rows won");
            if (winBin >= 31 && winBin <= 36)
                Console.WriteLine("Last two rows won");
        }
        public static void AdjacentBet(int[] matBin, int winBin)
        {
            if (winBin != 0 &&  winBin <= 34)
            {
                // Bet on Adjacent numbers
                if (winBin % 3 == 0) // Top row.
                    Console.WriteLine($"Adjacent numbers won: {matBin[winBin]}|{matBin[winBin + 1]}");
                if (winBin % 3 == 2) // Middle row.
                {
                    Console.WriteLine($"Adjacent numbers won: {matBin[winBin]}|{matBin[winBin + 1]}");
                    Console.WriteLine("and");
                    Console.WriteLine($"Adjacent numbers also won: {matBin[winBin]}|{matBin[winBin - 1]}");
                }
                if (winBin % 3 == 1) // Bottom row.
                    Console.WriteLine($"Adjacent numbers won: {matBin[winBin]}|{matBin[winBin - 1]}");
            }
            if (winBin == 35)
            {
                Console.WriteLine($"Adjacent numbers won: {matBin[winBin]}|{matBin[winBin - 1]}");
            }

        }
        public static void CornerBet(int[] matBin, int winBin)
        {
            Console.WriteLine("Corner numbers won:");
            if (winBin % 3 == 1) // Bottom row. 1, 4, 7 etc.
            {
                if (winBin >= 1 && winBin <= 31)
                {
                    Console.WriteLine($"{matBin[winBin + 1]}|{matBin[winBin + 4]}");
                    Console.WriteLine($"{matBin[winBin]}|{matBin[winBin + 3]}");
                }
            }
            if (winBin % 3 == 0) // Top row. 3, 6, 9 etc.
            {
                if (winBin >= 1 && winBin <= 33)
                {
                    Console.WriteLine($"{matBin[winBin]}|{matBin[winBin + 3]}");
                    Console.WriteLine($"{matBin[winBin - 1]}|{matBin[winBin + 2]}");
                }
            }
            if (winBin % 3 == 2) // Middle row. 2, 5, 8 etc.
            {
                if (winBin >= 2 && winBin <=32)
                {
                    Console.WriteLine($"{matBin[winBin + 1]}|{matBin[winBin + 4]}");
                    Console.WriteLine($"{matBin[winBin]}|{matBin[winBin + 3]}");
                    Console.WriteLine("and");
                    Console.WriteLine($"{matBin[winBin]}|{matBin[winBin + 3]}");
                    Console.WriteLine($"{matBin[winBin - 1]}|{matBin[winBin + 2]}");
                }

            }
        }
    }
}
