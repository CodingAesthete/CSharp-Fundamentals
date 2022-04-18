using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();
            int sum = 0;
            bool check = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == int.Parse(command[0]))
                {
                    check = true;
                }
            }
            if (check == false)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
            }
            else if (check == true)
            {
                int index = 0;
                int times = int.Parse(command[1]);
                int stop = 0;
                int start = 0;
                while (numbers.Contains(int.Parse(command[0])))
                {
                    index = numbers.IndexOf(int.Parse(command[0]));
                    stop = Math.Min((index + times), numbers.Count - 1);
                    start = Math.Max((index - times), 0);
                    for (int i = start; i <= stop; i++)
                    {
                        numbers.Remove(numbers[start]);
                    }

                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
