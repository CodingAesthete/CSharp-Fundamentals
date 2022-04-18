using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            int num = 0;
            Dictionary<string, int> sorted = new Dictionary<string, int>();
            Dictionary<string, int> sorted2 = new Dictionary<string, int>();
            while (true)
            {

                bool check = false;
                string[] input = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < input.Length; i++)
                {
                    counter++;
                    if (counter % 2 != 0)
                    {
                        num = int.Parse(input[i]);
                    }
                    else
                    {
                        string ros = input[i].ToLower();
                        ros.ToLower();
                        if (ros == "shards" || ros == "fragments" || ros == "motes")
                        {

                            if (sorted.ContainsKey(ros))
                            {

                                sorted[ros] += num;
                            }
                            else
                            {
                                sorted.Add(ros, num);
                            }
                            if (sorted.ContainsKey("shards"))
                            {
                                if (sorted["shards"] >= 250)
                                {
                                    Console.WriteLine("Shadowmourne obtained!");
                                    sorted["shards"] -= 250;
                                    if (true)
                                    {

                                    }
                                    check = true;
                                    break;
                                }
                            }
                            if (sorted.ContainsKey("fragments"))
                            {
                                if (sorted["fragments"] >= 250)
                                {
                                    Console.WriteLine("Valanyr obtained!");
                                    sorted["fragments"] -= 250;
                                    check = true;
                                    break;
                                }
                            }
                            if (sorted.ContainsKey("motes"))
                            {
                                if (sorted["motes"] >= 250)
                                {
                                    Console.WriteLine("Dragonwrath obtained!");
                                    sorted["motes"] -= 250;
                                    check = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (sorted2.ContainsKey(ros))
                            {
                                sorted2[ros] += num;
                            }
                            else
                            {
                                sorted2.Add(ros, num);
                            }
                        }
                    }
                }
                if (check == true)
                {
                    break;
                }
            }
            foreach (var item in sorted.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            if (!sorted.ContainsKey("fragments") || sorted["fragments"] == 0)
            {
                Console.WriteLine("fragments: 0");
            }
            if (!sorted.ContainsKey("motes") || sorted["motes"] == 0)
            {
                Console.WriteLine("motes: 0");
            }
            if (!sorted.ContainsKey("shards") || sorted["shards"] == 0)
            {
                Console.WriteLine("shards: 0");
            }
            foreach (var item in sorted2.OrderBy(s => s.Key))
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}