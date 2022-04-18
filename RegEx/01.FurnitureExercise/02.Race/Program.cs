using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main()
        {
            List<string> neu = new List<string>();
            Dictionary<string, int> sorted = new Dictionary<string, int>();
            string[] names = Console.ReadLine().Split(", ").ToArray();
            string pattern = @"[A-Za-z]+";
            Regex regex = new Regex(pattern);
            string input;
            string pattern2 = @"\d";
            Regex regex2 = new Regex(pattern2);
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder result = new StringBuilder();
                StringBuilder result2 = new StringBuilder();
                var matches = regex.Matches(input);
                var matches2 = regex2.Matches(input);
                for (int i = 0; i < matches.Count; i++)
                {
                    result.Append(matches[i]);
                }
                for (int i = 0; i < matches2.Count; i++)
                {
                    result2.Append(matches2[i]);
                }
                for (int i = 0; i < names.Length; i++)
                {
                    int count = 0;
                    if (names[i] == result.ToString())
                    {
                        string naam = result.ToString();
                        if (!sorted.ContainsKey(naam))
                        {
                            sorted.Add(naam, 0);
                        }
                        for (int j = 0; j < matches2.Count; j++)
                        {
                            count += int.Parse(matches2[j].ToString());
                        }
                        sorted[naam] += count;
                    }
                }
            }
            int counte = 1;
            foreach (var item in sorted.OrderByDescending(s => s.Value).Take(3))
            {
                string text = counte == 1 ? "st" : counte == 2 ? "nd" : "rd";
                Console.WriteLine($"{counte}{text} place: {item.Key}");
                counte++;
            }
        }
    }
}
