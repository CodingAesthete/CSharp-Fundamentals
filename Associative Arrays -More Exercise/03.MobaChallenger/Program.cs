using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MobaChallenger
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> sorted = new Dictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] command = input.Split(" -> ").ToArray();
                    string player = command[0];
                    string position = command[1];
                    int skill = int.Parse(command[2]);
                    if (!sorted.ContainsKey(player))
                    {
                        sorted[player] = new Dictionary<string, int>();
                    }
                    if (sorted.ContainsKey(player) && !sorted[player].ContainsKey(position))
                    {
                        sorted[player][position] = 0;
                    }
                    if (sorted[player][position] < skill)
                    {
                        sorted[player][position] = skill;
                    }
                }
                else if (input.Contains("vs"))
                {
                    string remove = "";
                    string[] command = input.Split(" vs ").ToArray();
                    string first = command[0];
                    string second = command[1];
                    if (sorted.ContainsKey(first) && sorted.ContainsKey(second))
                    {
                        foreach (var rol in sorted[first])
                        {
                            foreach (var role in sorted[second])
                            {
                                if (rol.Key == role.Key)
                                {
                                    if (sorted[first].Values.Sum() > sorted[second].Values.Sum())
                                    {
                                        remove = second;
                                    }
                                    else if (sorted[first].Values.Sum() < sorted[second].Values.Sum())
                                    {
                                        remove = first;
                                    }
                                }
                            }
                        }
                    }
                    sorted.Remove(remove);
                }
            }
            foreach (var item in sorted.OrderByDescending(s => s.Value.Values.Sum()).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");
                foreach (var itemo in item.Value.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                {
                    Console.WriteLine($"- {itemo.Key} <::> {itemo.Value}");
                }
            }
        }
    }
}