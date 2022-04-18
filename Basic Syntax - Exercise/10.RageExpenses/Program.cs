using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double expenses = 0;
            int brokenKeyboards = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                bool check1 = false;
                bool check2 = false;

                if (i % 2 == 0)
                {
                    check1 = true;
                    expenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    check2 = true;
                    expenses += mousePrice;
                }
                if (check1 && check2)
                {
                    expenses += keyboardPrice;
                    brokenKeyboards++;

                    if (brokenKeyboards % 2 == 0)
                    {
                        expenses += displayPrice;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
