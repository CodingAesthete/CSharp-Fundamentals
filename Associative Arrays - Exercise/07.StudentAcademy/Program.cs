using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> sorted = new Dictionary<string, List<double>>();
            Dictionary<string, double> sorted2 = new Dictionary<string, double>();
            int count = int.Parse(Console.ReadLine());
            string name = "";
            for (int i = 0; i < count * 2; i++)
            {
                if (i % 2 == 0)
                {
                    name = Console.ReadLine();
                }
                else
                {
                    double note = double.Parse(Console.ReadLine());
                    if (!sorted.ContainsKey(name))
                    {
                        sorted.Add(name, new List<double>() { note });
                    }
                    else
                    {
                        sorted[name].Add(note);
                    }
                }

            }
            foreach (var item in sorted)
            {
                double sum = 0;
                foreach (var itemo in item.Value)
                {
                    sum += itemo;
                }
                sum /= item.Value.Count;
                sorted2.Add(item.Key, sum);
            }
            foreach (var item in sorted2.OrderByDescending(s => s.Value))
            {
                if (item.Value >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:f2}");
                }
            }
        }
    }
}