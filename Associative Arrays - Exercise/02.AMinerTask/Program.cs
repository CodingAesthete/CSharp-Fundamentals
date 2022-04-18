using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            string input;
            while ((input=Console.ReadLine())!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(input))
                {
                    dictionary[input] = 0;
                }

                dictionary[input] += quantity;
            }

            foreach (var resourse in dictionary)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
