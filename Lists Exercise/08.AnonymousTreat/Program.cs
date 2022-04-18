using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.AnonymousTreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split();
                if (command[0] == "merge")
                {
                    StringBuilder result = new StringBuilder();
                    int first = int.Parse(command[1]);
                    int second = int.Parse(command[2]);
                    if ((first < 0 && second < 0) || (first > numbers.Count && second > numbers.Count))
                    {
                        continue;
                    }
                    else
                    {
                        int start = Math.Max(0, first);
                        int stop = Math.Min(numbers.Count - 1, second);
                        for (int i = start; i <= stop; i++)
                        {
                            result.Append(numbers[start]);
                            numbers.RemoveAt(start);
                        }
                        numbers.Insert(start, result.ToString());
                    }
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    if (index < 0 && index > numbers.Count - 1)
                    {
                        break;
                    }
                    else
                    {
                        List<string> neu = new List<string>();
                        string word = numbers[index];
                        int lenth = word.Length / partitions;
                        int start = 0;
                        for (int i = 0; i < partitions; i++)
                        {
                            if (i == partitions - 1)
                            {
                                neu.Add(word.Substring(start, word.Length - start));
                            }
                            else
                            {
                                neu.Add(word.Substring(start, lenth));
                                start += lenth;
                            }

                        }
                        numbers.RemoveAt(index);
                        numbers.InsertRange(index, neu);
                    }
                }

            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
