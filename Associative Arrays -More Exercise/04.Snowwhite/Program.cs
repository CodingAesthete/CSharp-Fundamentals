using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> sorted = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] command = input.Split(" <:> ").ToArray();
                string Name = command[0];
                string Color = command[1];
                int Physics = int.Parse(command[2]);
                string klyuch = Name + ":" + Color;
                if (!sorted.ContainsKey(klyuch))
                {
                    sorted[klyuch] = Physics;
                }
                else if (sorted.ContainsKey(klyuch))
                {
                    if (sorted[klyuch] < Physics)
                    {
                        sorted[klyuch] = Physics;
                    }
                }
            }
            foreach (var item in sorted.OrderByDescending(s => s.Value).ThenByDescending(x => sorted.Where(s => s.Key.Split(":")[1] == x.Key.Split(":")[1]).Count()))
            {
                string name = item.Key.Split(":")[0];
                string color = item.Key.Split(":")[1];
                Console.WriteLine($"({color}) {name} <-> {item.Value}");
            }
        }
    }
}
