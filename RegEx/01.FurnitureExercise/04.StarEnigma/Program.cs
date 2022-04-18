using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> sorted = new Dictionary<string, List<string>>();
            int times = int.Parse(Console.ReadLine());
            string pattern = @"[starSTAR]";
            Regex regex = new Regex(pattern);
            string pattern2 = @"@(?<planet>[A-Za-z]+)([^@\-!:>])*:(?<population>[0-9]+)([^@\-!:>])*!(?<type>[AD])!([^@\-!:>])*->(?<soldiers>[0-9]+)";
            Regex regex2 = new Regex(pattern2);
            string input;
            for (int i = 0; i < times; i++)
            {
                StringBuilder result = new StringBuilder();
                input = Console.ReadLine();
                var matches = regex.Matches(input);
                int count = matches.Count;
                for (int j = 0; j < input.Length; j++)
                {
                    int num = ((int)input[j]) - count;
                    char letter = (char)num;
                    result.Append(letter);
                }
                string raw = result.ToString();
                var match = regex2.Match(raw);
                if (match.Success)
                {
                    string planeta = match.Groups["planet"].Value;
                    string type = match.Groups["type"].Value;
                    if (!sorted.ContainsKey(type))
                    {
                        sorted.Add(type, new List<string>());
                        sorted[type].Add(planeta);
                    }
                    else if (sorted.ContainsKey(type))
                    {
                        sorted[type].Add(planeta);
                    }
                }
            }
            if (!sorted.ContainsKey("A"))
            {
                Console.WriteLine("Attacked planets: 0");
            }
            else if (sorted.ContainsKey("A"))
            {
                Console.WriteLine($"Attacked planets: {sorted["A"].Count}");
                foreach (var item in sorted["A"].OrderBy(s => s))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            if (!sorted.ContainsKey("D"))
            {
                Console.WriteLine("Destroyed planets: 0");
            }
            else if (sorted.ContainsKey("D"))
            {
                Console.WriteLine($"Destroyed planets: {sorted["D"].Count}");
                foreach (var item in sorted["D"].OrderBy(s => s))
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
