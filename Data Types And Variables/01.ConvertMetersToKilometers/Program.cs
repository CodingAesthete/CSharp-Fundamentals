using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kms = meters * 1.0m / 1000;
            Console.WriteLine($"{kms:f2}");
        }
    }
}
