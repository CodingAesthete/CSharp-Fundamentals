using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double money = 0;

            while ((input=Console.ReadLine())!="Start")
            {
                double coin = double.Parse(input);

                if(coin!=0.1 && coin!=0.2 && coin!=0.5 && coin!=1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    continue;
                }

                money += coin;
            }

            string product;

            while ((product=Console.ReadLine())!="End")
            {
                double price = 0;

                if (product == "Nuts")
                {
                    price = 2;
                }
                else if (product == "Coke")
                {
                    price = 1;
                }
                else if (product == "Crisps")
                {
                    price = 1.5;
                }
                else if (product == "Soda")
                {
                    price = 0.8;
                }
                else if (product == "Water")
                {
                    price = 0.7;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (money-price<0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    money -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
            }

            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
