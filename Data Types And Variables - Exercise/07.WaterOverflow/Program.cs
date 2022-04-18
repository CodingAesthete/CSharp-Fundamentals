using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int filled = 0;

            for (int i = 0; i < n; i++)
            {
                int pourWater = int.Parse(Console.ReadLine());

                if (filled+pourWater>capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    filled += pourWater;
                }
            }

            Console.WriteLine(filled);
        }
    }
}
