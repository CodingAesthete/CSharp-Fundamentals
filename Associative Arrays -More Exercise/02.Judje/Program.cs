using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judje
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> sorted = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> sorted2 = new Dictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] command = input.Split(" -> ").ToArray();
                string name = command[0];
                string course = command[1];
                int points = int.Parse(command[2]);
                if (!sorted.ContainsKey(course))
                {
                    sorted.Add(course, new Dictionary<string, int>());
                }
                if (sorted.ContainsKey(course) && !sorted[course].ContainsKey(name))
                {
                    sorted[course].Add(name, 0);
                }
                if (sorted[course][name] < points)
                {
                    sorted[course][name] = points;
                }
                if (!sorted2.ContainsKey(name))
                {
                    sorted2.Add(name, new Dictionary<string, int>());
                }
                if (sorted2.ContainsKey(name) && !sorted2[name].ContainsKey(course))
                {
                    sorted2[name].Add(course, 0);
                }
                if (sorted2[name][course] < points)
                {
                    sorted2[name][course] = points;
                }
            }
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Keys.Count} participants");
                int count = 0;
                foreach (var itemo in item.Value.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                {
                    count++;
                    Console.WriteLine($"{count}. {itemo.Key} <::> {itemo.Value}");
                }
            }
            List<string> result = new List<string>();
            Console.WriteLine("Individual standings:");
            int counte = 0;
            foreach (var item in sorted2.OrderByDescending(s => s.Value.Values.Sum()).ThenBy(s => s.Key))
            {
                if (result.Contains(item.Key))
                {
                    continue;
                }
                else
                {
                    counte++;
                    string current = item.Key;
                    foreach (var itemo in item.Value)
                    {
                        if (!result.Contains(current))
                        {
                            int counter = sorted2[current].Values.Sum();
                            Console.WriteLine($"{counte}. {current} -> {counter}");
                            result.Add(item.Key);
                        }
                    }
                }
            }
        }
    }
}
