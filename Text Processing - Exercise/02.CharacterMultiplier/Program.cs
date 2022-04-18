using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string first = input[0];
            string second = input[1];
            string longest = first;
            string shortest = second;
            if (first.Length < second.Length)
            {
                longest = second;
                shortest = first;
            }
            int result = Result(longest, shortest);
            Console.WriteLine(result);
        }
        public static int Result(string longest, string shortest)
        {
            int sum = 0;
            for (int i = 0; i < shortest.Length; i++)
            {
                int multiply = shortest[i] * longest[i];
                sum += multiply;
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }

            return sum;
        }
    }
}
