using System;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the garbage collection demo lab");
            //Calculator calc = new Calculator();
            //double result = calc.Divide(120, 15);
            //Console.WriteLine($"120 / 15 = {result}");
            Console.WriteLine("===========================================================");
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"120 / 0 = {calculator.Divide(120, 0)}");
            }
            Console.WriteLine("Program finishing");
        }
    }
}
