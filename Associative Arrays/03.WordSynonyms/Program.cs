using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                if (!dictionary.ContainsKey(key))
                {
                    dictionary[key] = new List<string>();
                }
                dictionary[key].Add(value);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ",item.Value)}");
            }
        }
    }
}
