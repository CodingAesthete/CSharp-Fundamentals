using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int num = numbers[i];
                while (num != 0)
                {
                    int digital = num % 10;
                    sum += digital;
                    num /= 10;
                }
                int count = 0;
                for (int j = 0; j < sum; j++)
                {
                    count++;
                    if (count > input.Length - 1)
                    {
                        count = 0;
                    }
                }
                char letter = input[count];
                Console.Write(letter);
                string input2 = input.Remove(count, 1);
                input = input2;
            }
        }
    }
}
