using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double currPrice = ((days * capsulesCount) * capsulePrice);
                totalPrice += currPrice;

                Console.WriteLine($"The price for the coffee is: ${currPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
