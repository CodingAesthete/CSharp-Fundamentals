using System;
using System.Collections.Generic;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            List<char> characters = new List<char>();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                int digital = (int)input[i];
                if (digital >= 48 && digital <= 57)
                {
                    int added = int.Parse(input[i].ToString());
                    numbers.Add(added);
                }
                else
                {
                    characters.Add(input[i]);
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 1)
                {
                    skip.Add(numbers[i]);
                }
                else
                {
                    take.Add(numbers[i]);
                }
            }
            int taken;
            int skipped;
            int start = 0;
            int second = 0;
            for (int i = 0; i < take.Count; i++)
            {
                taken = take[i];
                second = start + taken;
                int stop = Math.Min(second, characters.Count);
                for (int j = start; j < stop; j++)
                {
                    result += characters[j];
                }
                if (stop == characters.Count - 1)
                {
                    break;
                }
                start += taken;
                skipped = skip[i];
                start += skipped;
            }
            Console.WriteLine(result);
        }
    }
}
