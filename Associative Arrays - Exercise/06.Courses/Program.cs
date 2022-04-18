using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> sorted = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ").ToArray();
                string course = command[0];
                string name = command[1];
                if (!sorted.ContainsKey(course))
                {
                    sorted.Add(course, new List<string>() { name });
                }
                else
                {
                    sorted[course].Add(name);
                }
            }
            foreach (var item in sorted.OrderByDescending(s => s.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var itemo in item.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {itemo}");
                }
            }
        }
    }
}
