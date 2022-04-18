using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.SecretHelperOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sorted = new Dictionary<string, string>();
            string pattern = @"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]+\!(?<sign>[GN])\!";
            Regex regex = new Regex(pattern);
            int count = int.Parse(Console.ReadLine());
            string input;
            if (count >= 1 && count <= 100)
            {
                while ((input = Console.ReadLine()) != "end")
                {
                    StringBuilder result = new StringBuilder();
                    for (int j = 0; j < input.Length; j++)
                    {
                        int num = input[j] - count;
                        string letter = ((char)num).ToString();
                        result.Append(letter);
                    }
                    string output = result.ToString();
                    var match = regex.Match(output);
                    if (match.Success)
                    {
                        string name = match.Groups["name"].Value;
                        string sign = match.Groups["sign"].Value;
                        if (sign == "G")
                        {
                            sorted.Add(name, sign);
                        }
                    }
                }
                foreach (var item in sorted)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
