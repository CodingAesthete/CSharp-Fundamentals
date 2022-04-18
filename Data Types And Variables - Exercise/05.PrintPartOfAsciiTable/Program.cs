using System;

namespace _05.PrintPartOfAsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());

            for (int i = startInterval; i <= endInterval; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
        }
    }
}
