using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07
{
    class MakeWheel
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

            Console.WriteLine("Below is the text representation of the American standard Roulette wheel we will be using:");
            for (int i = 0; i <= numBin.Length - 1; i++)
            {
                Console.WriteLine($"Bin: {numBin[i]} Color: {colorBin[i]}");
            }

            return (numBin, colorBin);
        }
        public static int[] CreateMat()
        {
            int[] mat = new int[36];
            for (int i = 0; i < mat.Length; i++)
            {
                mat[i] = i;
            }
            return mat;
        }
        public static int BallDrop(int[] wheel)
        {
            Random random = new Random();

            int winningBin = random.Next(wheel.Length);
            return winningBin;
        }
    }
}
