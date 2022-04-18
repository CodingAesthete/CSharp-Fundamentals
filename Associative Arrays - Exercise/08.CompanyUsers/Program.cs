using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> sorted = new Dictionary<String, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" -> ").ToArray();
                string course = command[0];
                string num = command[1];
                if (!sorted.ContainsKey(course))
                {
                    sorted.Add(course, new List<string>() { num });
                }
                else
                {
                    if (!sorted[course].Contains(num))
                    {
                        sorted[course].Add(num);
                    }

                }
            }
            foreach (var item in sorted.OrderBy(s => s.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var itemo in item.Value)
                {
                    Console.WriteLine($"-- {itemo}");
                }
            }
        }
    }
}
