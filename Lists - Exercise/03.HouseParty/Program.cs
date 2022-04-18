using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> invited = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                string name = command[0];

                if (command.Count==3)
                {
                    if (!invited.Contains(name))
                    {
                        invited.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (invited.Contains(name))
                    {
                        invited.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(String.Join("\n",invited));
        }
    }
}
