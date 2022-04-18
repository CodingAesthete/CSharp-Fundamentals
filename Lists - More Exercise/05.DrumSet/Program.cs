using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> neu = new List<int>();
            neu.AddRange(drums);
            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                decimal sum = 0;
                int power = int.Parse(input);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= power;
                    if (drums[i] <= 0)
                    {
                        sum = neu[i] * 3;
                        if (money - sum > 0)
                        {
                            drums[i] = neu[i];
                            money -= sum;
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            neu.RemoveAt(i);
                            i--;
                        }

                    }
                }
            }
            Console.WriteLine(String.Join(" ", drums));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
