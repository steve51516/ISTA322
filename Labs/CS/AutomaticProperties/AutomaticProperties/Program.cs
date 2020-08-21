using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class Program
    {
        static void doWork()
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon { NumSides = 3 };
            Polygon pentagon = new Polygon { SideLength = 15.5, NumSides = 5 };
            Polygon octagon = new Polygon { NumSides = 8, SideLength = 4 };

            Console.WriteLine($"Square: number of sides is {square.NumSides}, length of each side is { square.SideLength }");
            Console.WriteLine($"Triangle: number of sides is {triangle.NumSides}, length of each side is { triangle.SideLength }");
            Console.WriteLine($"Pentagon: number of sides is {pentagon.NumSides}, length of each side is { pentagon.SideLength }");
            Console.WriteLine($"Octagon: number of sides is {octagon.NumSides}, length of each side is {octagon.SideLength}");
        }

        static void Main(string[] args)
        {
                doWork();
        }
    }
    class Polygon
    {
        public int NumSides { get; set; }
        public double SideLength { get; set; }
        public Polygon()
        {
            this.NumSides = 4;
            this.SideLength = 10.0;
        }
    }
}
