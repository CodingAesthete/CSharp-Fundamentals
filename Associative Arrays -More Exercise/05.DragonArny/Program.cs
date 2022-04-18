using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArny
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<double>>> sorted = new Dictionary<string, Dictionary<string, List<double>>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string type = command[0];
                string name = command[1];
                double damage;
                double health;
                double armor;
                if (command[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = double.Parse(command[2]);
                }
                if (command[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = double.Parse(command[3]);
                }
                if (command[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = double.Parse(command[4]);
                }

                if (!sorted.ContainsKey(type))
                {
                    sorted[type] = new Dictionary<string, List<double>>();
                }
                if (sorted.ContainsKey(type))
                {
                    if (!sorted[type].ContainsKey(name))
                    {
                        sorted[type][name] = new List<double>() { damage, health, armor };
                    }
                    else
                    {
                        sorted[type][name] = new List<double>() { damage, health, armor };
                    }
                }
            }
            foreach (var type in sorted)
            {
                Console.WriteLine($"{type.Key}::({(type.Value.Select(s => s.Value[0]).Average()):F2}/{(type.Value.Select(s => s.Value[1]).Average()):F2}/{(type.Value.Select(s => s.Value[2]).Average()):F2})");
                foreach (var item in type.Value.OrderBy(s => s.Key))
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}");
                }
            }
        }
    }
}

