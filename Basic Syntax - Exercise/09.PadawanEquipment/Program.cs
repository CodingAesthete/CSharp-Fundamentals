using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double add = Math.Ceiling(0.1 * students);
            int extracted = students / 6;

            double totalPrice = ((students+add) * lightsabrePrice) + students*robePrice + (students-extracted)* beltPrice;


            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice-money):F2}lv more.");
            }
        }
    }
}
