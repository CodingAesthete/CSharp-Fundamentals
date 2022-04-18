using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                PrintingTriangle(1, i);
            }
            for (int i = num-1; i >=1; i--)
            {
                PrintingTriangle(1, i);
            }
        }

        private static void PrintingTriangle(int v, int i)
        {
            for (int j = v; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
