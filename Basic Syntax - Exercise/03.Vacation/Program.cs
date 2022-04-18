using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;

            if (dayOfTheWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 8.45 * people;
                    if (people >= 30)
                    {
                        price = 0.85 * price;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    if (people >= 100)
                    {
                        people -= 10;
                    }
                    price = 10.90 * people;
                }
                else
                {
                    price = 15 * people;
                    if(people>=10 && people <= 20)
                    {
                        price = 0.95 * price;
                    }
                }
            }
            else if (dayOfTheWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 9.80 * people;
                    if (people >= 30)
                    {
                        price = 0.85 * price;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    if (people >= 100)
                    {
                        people -= 10;
                    }
                    price = 15.60 * people;
                }
                else
                {
                    price = 20 * people;
                    if (people >= 10 && people <= 20)
                    {
                        price = 0.95 * price;
                    }
                }
            }
            else if (dayOfTheWeek=="Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    price = 10.46 * people;
                    if (people >= 30)
                    {
                        price = 0.85 * price;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    if (people >= 100)
                    {
                        people -= 10;
                    }
                    price = 16 * people;
                }
                else
                {
                    price = 22.50 * people;
                    if (people >= 10 && people <= 20)
                    {
                        price = 0.95 * price;
                    }
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
