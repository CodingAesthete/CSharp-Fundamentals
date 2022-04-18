using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCap = int.Parse(Console.ReadLine());

            string input;
            while ((input=Console.ReadLine())!="end")
            {
                List<string> list = input.Split().ToList();

                if (list.Count==1)
                {
                    
                    int passangers = int.Parse(list[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (passangers + wagons[i] > maxCap)
                        {
                            continue;
                        }
                        else
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }
                else
                {
                    wagons.Add(int.Parse(list[1]));
                }
            }

            Console.WriteLine(String.Join(" ",wagons));
        }
    }
}
