using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            VendingMachine(drink, quantity);
        }

        private static void VendingMachine(string drink, int quantity)
        {
            decimal sum = 0;
            if (drink=="coffee")
            {
                sum += 1.50m * quantity;
            }
            else if (drink == "water")
            {
                sum += 1.00m * quantity;
            }
            else if (drink == "coke")
            {
                sum += 1.40m * quantity;
            }
            else if (drink == "snacks")
            {
                sum += 2.00m * quantity;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
