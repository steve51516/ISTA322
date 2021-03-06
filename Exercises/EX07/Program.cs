﻿using System;

namespace EX07
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayRoulette();
        }
        static void PlayRoulette()
        {
            var wheel = MakeWheel.CreateWheel();
            Console.WriteLine("\n");
            int winBin = MakeWheel.BallDrop(wheel.Item1);
            int[] bettingMat = MakeWheel.CreateMat();
            Roulette.BinBet(winBin);
            Roulette.ColorsBet(wheel.Item2, winBin);
            Roulette.LowsHighsBet(winBin);
            Roulette.DozensBet(winBin);
            Roulette.ColumnsBet(winBin);
            Roulette.StreetBet(winBin);
            Roulette.SixBet(winBin);
            Roulette.AdjacentBet(bettingMat, winBin);
            Roulette.CornerBet(bettingMat, winBin);
        }
    }
}
