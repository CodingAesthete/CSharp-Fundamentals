using System;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(@"\");
            string word = input.Last();
            string[] wor = word.Split(".");
            string name = wor[0];
            string ext = wor[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}
