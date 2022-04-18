using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDoNotGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int removed = numbers[0];
                    sum += removed;
                    numbers.RemoveAt(0);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (removed >= numbers[i])
                        {
                            numbers[i] += removed;
                        }
                        else
                        {
                            numbers[i] -= removed;
                        }
                    }
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                }
                else if (index > numbers.Count - 1)
                {
                    int removed = numbers[numbers.Count - 1];
                    sum += removed;
                    numbers.RemoveAt(numbers.Count - 1);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (removed >= numbers[i])
                        {
                            numbers[i] += removed;
                        }
                        else
                        {
                            numbers[i] -= removed;
                        }
                    }
                    numbers.Insert(numbers.Count, numbers[0]);
                }
                else
                {
                    int removed = numbers[index];
                    numbers.RemoveAt(index);
                    sum += removed;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (removed >= numbers[i])
                        {
                            numbers[i] += removed;
                        }
                        else
                        {
                            numbers[i] -= removed;
                        }
                    }

                }
            }
            Console.WriteLine(sum);
        }
    }
}
