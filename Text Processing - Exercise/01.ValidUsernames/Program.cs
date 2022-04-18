using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(", ").ToList();

            foreach (var word in words)
            {
                bool check = true;
                for (int i = 0; i < word.Length; i++)
                {
                    char curr = word[i];
                    if (!(char.IsDigit(curr) || char.IsLetter(curr) || curr == '-' || curr == '_'))
                    {
                        check = false;
                    }
                }

                if (check && (word.Length>=3 && word.Length<=16))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
