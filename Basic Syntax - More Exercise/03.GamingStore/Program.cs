using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currBalance = decimal.Parse(Console.ReadLine());
            string game;
            decimal totalSpent = 0;

            while ((game=Console.ReadLine())!="Game Time")
            {
                decimal price = 0;

                if (game == "OutFall 4")
                {
                    price = 39.99m;
                }
                else if (game == "CS: OG")
                {
                    price = 15.99m;
                }
                else if (game == "Zplinter Zell")
                {
                    price = 19.99m;
                }
                else if (game == "Honored 2")
                {
                    price = 59.99m;
                }
                else if (game == "RoverWatch")
                {
                    price = 29.99m;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99m;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (currBalance - price >= 0)
                {
                    Console.WriteLine($"Bought { game}");
                    currBalance -= price;

                    if (currBalance==0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                totalSpent += price;
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currBalance:f2}");
        }
    }
}
