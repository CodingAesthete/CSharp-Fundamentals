using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main()
        {
            string pattern = @">>(?<article>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)\!(?<count>\d+)";
            Regex regex = new Regex(pattern);
            List<string> nouns = new List<string>();
            double sum = 0;
            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    string article = match.Groups["article"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int count = int.Parse(match.Groups["count"].Value);
                    nouns.Add(article);
                    sum += (price * count);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in nouns)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}