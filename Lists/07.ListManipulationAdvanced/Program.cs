using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            List<int> Odd = new List<int>();
            List<int> Even = new List<int>();
            List<int> Pir = new List<int>();
            List<int> Pog = new List<int>();
            List<int> Pom = new List<int>();
            List<int> Pmr = new List<int>();
            bool check = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ").ToArray();

                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    check = true;
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) > numbers.Count - 1)
                    {
                        continue;
                    }
                    numbers.Remove(int.Parse(command[1]));
                    check = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    if (int.Parse(command[1]) > numbers.Count - 1)
                    {
                        continue;
                    }
                    numbers.RemoveAt(int.Parse(command[1]));
                    check = true;
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) > numbers.Count - 1)
                    {
                        continue;
                    }
                    int a = int.Parse(command[1]);
                    int b = int.Parse(command[2]);
                    numbers.Insert(b, a);
                    check = true;
                }
                else if (command[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Even.Add(numbers[i]);
                        }
                    }
                    foreach (var item in Even)
                    {
                        Console.Write($"{item} ");

                    }
                    Console.WriteLine();
                }
                else if (command[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            Odd.Add(numbers[i]);
                        }
                    }
                    foreach (var item in Odd)
                    {
                        Console.Write($"{item} ");

                    }
                    Console.WriteLine();

                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command[0] == "Filter")
                {

                    if (command[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= int.Parse(command[2]))
                            {
                                Pir.Add(numbers[i]);
                            }
                        }
                        foreach (var item in Pir)
                        {
                            Console.Write($"{item} ");

                        }
                        Console.WriteLine();
                    }
                    else if (command[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > int.Parse(command[2]))
                            {
                                Pog.Add(numbers[i]);
                            }
                        }
                        foreach (var item in Pog)
                        {
                            Console.Write($"{item} ");

                        }
                        Console.WriteLine();
                    }
                    else if (command[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < int.Parse(command[2]))
                            {
                                Pom.Add(numbers[i]);
                            }
                        }
                        foreach (var item in Pom)
                        {
                            Console.Write($"{item} ");

                        }
                        Console.WriteLine();
                    }
                    else if (command[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= int.Parse(command[2]))
                            {
                                Pmr.Add(numbers[i]);
                            }
                        }
                        foreach (var item in Pmr)
                        {
                            Console.Write($"{item} ");

                        }
                        Console.WriteLine();
                    }

                }
            }
            if (check == true)
            {
                foreach (var i in numbers)
                {
                    Console.Write($"{i} ");

                }

            }
        }
    }
}
