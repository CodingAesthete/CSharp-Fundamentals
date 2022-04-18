using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> listo = new List<char>();
            List<int> nunos = new List<int>();
            Dictionary<char, int> sorted = new Dictionary<char, int>();
            Dictionary<char, string> sorted2 = new Dictionary<char, string>();
            string[] input = Console.ReadLine().Split("|").ToArray();
            string first = input[0];
            string second = input[1];
            string third = input[2];
            string pattern = @"(\&|\#|\%|\*|\$)[A-Z]+\1";
            string pattern2 = @"\d+\:((0[1-9])|(1[0-9])|(20))";
            Regex regex = new Regex(pattern);
            Regex regex2 = new Regex(pattern2);
            var match = regex.Match(first);
            var matches = regex2.Matches(second);
            if (match.Success)
            {
                string mat = match.Value.ToString();
                string matu = mat.Substring(1, mat.Length - 2);
                foreach (var item in matu)
                {
                    char lil = item;
                    listo.Add(lil);
                    int nun = (int)lil;
                    nunos.Add(nun);
                }
                foreach (var item in matches)
                {
                    string raw = item.ToString();
                    string[] raws = raw.Split(":");
                    int s = int.Parse(raws[0]);
                    int count = int.Parse(raws[1]);
                    char letter = (char)(s);
                    if (!sorted.ContainsKey(letter) && (nunos.Contains(s)))
                    {

                        sorted.Add(letter, count);
                    }

                }
                string[] rav = third.Split();
                foreach (var item in rav)
                {
                    string word = item;
                    int counter = word.Length - 1;
                    char letter = word[0];
                    if (sorted.ContainsKey(letter))
                    {
                        if (sorted[letter] == counter)
                        {
                            sorted2.Add(word[0], word);
                        }
                    }
                }

            }
            for (int i = 0; i < listo.Count; i++)
            {
                char per = listo[i];
                Console.WriteLine(sorted2[per]);
            }
        }
    }
}