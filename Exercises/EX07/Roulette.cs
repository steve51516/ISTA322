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
            // Bet on Adjacent numbers
            if (winBin % 3 == 0)
                Console.WriteLine($"Adjacent numbers won: {matBin[winBin]}|{matBin[winBin - 1]}");
            if (winBin % 3 == 2)
            {
                Console.WriteLine($"Adjacent numbers won: {matBin[winBin]}|{matBin[winBin - 1]}");
                Console.WriteLine("and");
                Console.WriteLine($"Adjacent numbers also won: {matBin[winBin]}|{matBin[winBin + 1]}");
            }
            if (winBin % 3 == 1)
                Console.WriteLine($"Adjacent numbers won: {matBin[winBin]}|{matBin[winBin + 1]}");

        }
        //public static int Menu()
        //{
        //    Console.WriteLine("\n1: Bet on a bin number. Winnings are 35x1");
        //    Console.WriteLine("2: Bet on odds or even numbers.");
        //    Console.WriteLine("3: Bet on red or black colored numbers.");
        //    Console.WriteLine("4: Lows/Highs: low (1 - 18) or high (19 - 38) numbers.");
        //    Console.WriteLine("5: Dozens: row thirds, 1 - 12, 13 - 24, 25 - 36 ");
        //    Console.WriteLine("6. Columns: First, second, or third columns");
        //    Console.WriteLine("7: Street: rows, e.g., 1/2/3 or 22/23/24");
        //    Console.WriteLine("8: Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26");
        //    Console.WriteLine("9: Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36");
        //    Console.WriteLine("10: Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
        //    int x, selection = int.Parse(Console.ReadLine());
        //    switch (selection)
        //    {
        //        case 1:
        //            Console.WriteLine("Enter the bin number you want to bet on: ");
        //            x = int.Parse(Console.ReadLine());
        //            if (x > 0 && x <= 38)
        //            {
        //                CreateWheel();
        //                binBet(x);
        //            }
        //            else
        //            {
        //                Console.WriteLine("You must enter a valid bin number. Reference the table information at the top of the console.");
        //                Menu();
        //            }
        //            break;
        //        case 2:
        //            Console.WriteLine("1: for odds");
        //            Console.WriteLine("2: for evens");
        //            x = int.Parse(Console.ReadLine());
        //            if (x > 0 && x < 3)
        //                OddEvenBet(x);
        //            else
        //            {
        //                Console.WriteLine("You must enter 1 or 2 for odds or evens. Try again.");
        //                Menu();
        //            }
        //            break;
        //        case 3:
        //            Console.WriteLine("1: for reds");
        //            Console.WriteLine("2: for blacks");
        //            Console.Write("Enter selection: ");
        //            x = int.Parse(Console.ReadLine());
        //            if (x > 0 && x < 3)
        //            {
        //                if (x == 1)
        //                    colorsBet("red");
        //                if (x == 2)
        //                    colorsBet("black");
        //            }
        //            else
        //            {
        //                Console.WriteLine("You must enter 1 or 2 for reds or blacks. Try again.");
        //                Menu();
        //            }
        //            break;
        //        case 4:
        //            Console.WriteLine("1: for lows (1 - 18)");
        //            Console.WriteLine("2: for highs (19 - 38)");
        //            Console.Write("Enter selection: ");
        //            x = int.Parse(Console.ReadLine());
        //            if (x > 0 && x < 3)
        //            {
        //                lowsHighsBet(x);
        //            }
        //            else
        //            {
        //                Console.WriteLine("You must enter 1 or 2 for lows or highs. Try again.");
        //                Menu();
        //            }
        //            break;
        //        case 5:
        //            Console.WriteLine("1: 1 - 12");
        //            Console.WriteLine("2: 13 - 24");
        //            Console.WriteLine("3: 25 - 36");
        //            Console.Write("Select a dozen: ");
        //            x = int.Parse(Console.ReadLine());
        //            if (x >= 1 && x <= 3)
        //                dozensBet(x);
        //            else
        //            {
        //                Console.WriteLine("You must enter 1, 2, or 3 to select a dozen. Try again.");
        //                Menu();
        //            }
        //            break;
        //        case 6:
        //            Console.WriteLine("1: First");
        //            Console.WriteLine("2: Second");
        //            Console.WriteLine("3: Third");
        //            Console.Write("Select a column: ");
        //            x = int.Parse(Console.ReadLine());
        //            if (x > 0 && x < 4)
        //                columnsBet(x);
        //            else
        //            {
        //                Console.WriteLine("You must enter 1, 2, or 3 to select a dozen. Try again.");
        //                Menu();
        //            }
        //            break;
        //        case 7:
        //            Console.WriteLine("1: 1/2/3");
        //            Console.WriteLine("2: 4/5/6");
        //            Console.WriteLine("3: 7/8/9");
        //            Console.WriteLine("4: 10/11/12");
        //            Console.WriteLine("5: 13/14/15");
        //            Console.WriteLine("6: 16/17/18");
        //            Console.WriteLine("7: 19/20/21");
        //            Console.WriteLine("8: 22/23/24");
        //            Console.WriteLine("9: 25/26/27");
        //            Console.WriteLine("10: 28/29/30");
        //            Console.WriteLine("11: 31/32/33");
        //            Console.WriteLine("12: 34/35/36");
        //            Console.Write("Pick a Street: ");
        //            x = int.Parse(Console.ReadLine());
        //            if (x > 0 && x < 13)
        //                streetBet(x);
        //            else
        //            {
        //                Console.WriteLine("You must enter a an option of 1 - 13. Try again.");
        //                Menu();
        //            }
        //            break;
        //        case 8:
        //            Console.WriteLine("1: 1/2/3/4/5/6");
        //            Console.WriteLine("2: 7/8/9/10/11/12");
        //            Console.WriteLine("3: 13/14/15/16/17/18");
        //            Console.WriteLine("4: 19/20/21/22/23/24");
        //            Console.WriteLine("5: 22/23/24/25/26/27");
        //            Console.WriteLine("6: 28/29/30/34/35/36");
        //            Console.WriteLine("Enter a double street: ");
        //            x = int.Parse(Console.ReadLine());
        //            break;
        //        //case 9:
        //        //case 10:
        //        default:
        //            Console.WriteLine("Enter a selection between 1 and 10.");
        //            Menu();
        //            return 0;
        //    }
        //    return 0;
        //}
    }
}
