using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> sorted = new Dictionary<string, List<double>>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split().ToArray();
                string product = command[0];
                double price = double.Parse(command[1]);
                double count = int.Parse(command[2]);
                if (!sorted.ContainsKey(product))
                {
                    sorted.Add(product, new List<double>() { price, count });
                }
                else
                {
                    sorted[product][0] = price;
                    sorted[product][1] += count;
                }
            }
            foreach (var item in sorted)
            {
                double num = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {num:f2}");
            }
        }
    }
}
