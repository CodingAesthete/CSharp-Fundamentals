using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<decimal, decimal>> sorted = new Dictionary<string, Dictionary<decimal, decimal>>();
            string pattern = @", ";
            string pattern2 = @"[^\d\+\-\*\/\.]";
            string pattern3 = @"[-+]?\d+(\.\d+)?";
            string pattern4 = @"[*/]";
            Regex regex = new Regex(pattern);
            Regex regex2 = new Regex(pattern2);
            Regex regex3 = new Regex(pattern3);
            Regex regex4 = new Regex(pattern4);
            string command = Console.ReadLine();
            string[] input = command.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in input)
            {
                decimal count = 0;
                MatchCollection matches = regex2.Matches(item);
                if (matches.Count > 0)
                {
                    foreach (var itemo in matches)
                    {
                        string au = itemo.ToString();
                        decimal digit = (decimal)(char.Parse(au));
                        count += digit;
                    }
                }
                decimal count2 = 0;
                MatchCollection matches2 = regex3.Matches(item);
                if (matches2.Count > 0)
                {
                    foreach (var itemo in matches2)
                    {
                        string raw = itemo.ToString();
                        decimal num = decimal.Parse(raw);
                        count2 += num;
                    }
                }
                MatchCollection matches3 = regex4.Matches(item);
                if (matches3.Count > 0)
                {
                    foreach (var itemo in matches3)
                    {
                        string per = itemo.ToString();
                        if (per == "*")
                        {
                            count2 *= 2;
                        }
                        else if (per == "/")
                        {
                            count2 /= 2;
                        }
                    }
                }
                var inner = new Dictionary<decimal, decimal>();
                inner.Add(count, count2);
                sorted.Add(item, inner);
            }
            foreach (var item in sorted.OrderBy(s => s.Key))
            {
                if (item.Key.Length > 0 && (!item.Key.Contains(",") && !(item.Key.Contains(" "))))
                {
                    Console.Write($"{item.Key} - ");
                    foreach (var itemo in item.Value)
                    {
                        Console.WriteLine($"{itemo.Key} health, {itemo.Value:F2} damage");
                    }
                }

            }
        }
    }
}