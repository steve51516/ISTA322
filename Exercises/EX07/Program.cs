using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EX07
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Menu();
        }
    }
    public class Game
    {
        public (int[], string[]) CreateWheel()
        {
            
            // Creates American standard wheel.
            int[] numBin = { 0, 2, 14, 35, 23, 4, 16, 33, 21, 6, 18, 31, 19, 8, 12, 29, 25, 10, 27, 00, 1, 13, 36, 24, 3, 15, 34, 22, 5, 17, 32, 20, 7, 11, 30, 26, 9, 28 };
            string[] colorBin = new string[38];

            int x, y, z = 0;
            Random random = new Random();
            string[] randomColors = { "black", "red" };
            while(z < 38)
            {
                x = random.Next(0, 38);
                y = random.Next(0, 2);
                if (colorBin[x] == null)
                {
                    //Debuging info
                    //Console.WriteLine($"Bin {x} is {y}");
                    colorBin[x] = randomColors[y];
                    z++;
                }
            }

            colorBin[0] = "green";
            colorBin[19] = "green";

            Console.WriteLine("Below is the Roulette board's numbers and colors.");
            for (int i = 0; i <= numBin.Length - 1; i++)
            {
                Console.WriteLine($"Number is: {numBin[i]} Color for number is: {colorBin[i]}");
            }

            return (numBin, colorBin);
        }
        private static int BallDrop()
        {
            Random random = new Random();
            return random.Next(39);
        }
        public void BinBet(int bet)
        {
            int winningBin = BallDrop();
            Console.WriteLine($"The winning bin number is: {winningBin}");
            Console.WriteLine($"Your bet was: {bet}");
            if (bet == winningBin)
                Console.WriteLine("YOU WON!!! Please collect your winnings of 35x1 now!!!");
            else
                Console.WriteLine("Sorry you lost. Please play again.");
        }
        public static int Menu()
        {
            Console.WriteLine("\n1: Bet on a bin number.");
            Console.WriteLine("2: Bet on odds or even numbers.");
            Console.WriteLine("3: Bet on red or black colored numbers.");
            Console.WriteLine("4: Lows/Highs: low (1 { 18) or high (19 { 38) numbers.");
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
                        Game game1 = new Game();
                        var wheel = game1.CreateWheel();
                        game1.BinBet(x);
                    }
                    else
                    {
                        Console.WriteLine("You must enter a valid bin number. Reference the table information at the top of the console.");
                        Menu();
                    }
                    break;
                //case 2:
                //case 3:
                //case 4:
                //case 5:
                //case 6:
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
