using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < list.Count; i++)
            {
                string currWord = list[i];
                for (int j = 0; j < currWord.Length; j++)
                {
                    if (!dictionary.ContainsKey(currWord[j]))
                    {
                        dictionary[currWord[j]] = 0;
                    }
                    dictionary[currWord[j]]++;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
