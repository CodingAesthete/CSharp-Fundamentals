using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Randomize(input);
        }

        private static void Randomize(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                string temp = input[i];
                Random rnd = new Random();
                int index = rnd.Next(0, input.Count);
                input[i] = input[index];
                input[index] = temp;
            }

            Console.WriteLine(String.Join(Environment.NewLine,input));
        }
    }
}
