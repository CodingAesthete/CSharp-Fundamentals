using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                words.Add(input);
            }

            foreach (var item in words)
            {
                string str = new string(item.Reverse().ToArray());
                Console.WriteLine($"{item} = {str}");
            }
        }
    }
}
