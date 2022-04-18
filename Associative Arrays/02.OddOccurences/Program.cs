using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < input.Count; i++)
            {
                string currStr = input[i].ToLower();
                if (!dictionary.ContainsKey(currStr))
                {
                    dictionary[currStr]= 0;
                }
                dictionary[currStr]++;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var item in dictionary)
            {
                
                if (item.Value%2==1)
                {
                    sb.Append($"{item.Key} ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
