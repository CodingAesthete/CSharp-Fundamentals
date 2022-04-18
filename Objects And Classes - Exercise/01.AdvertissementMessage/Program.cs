using System;
using System.Collections.Generic;

namespace _01.AdvertissementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                MessageRandomizer();
            }
        }

        private static void MessageRandomizer()
        {
            List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string>() {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string>() {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            Random rand = new Random();
            string currPhrase = phrases[rand.Next(0, phrases.Count)];
            string currEvent = events[rand.Next(0, events.Count)];
            string currAuthor = authors[rand.Next(0, authors.Count)];
            string currCity = cities[rand.Next(0, cities.Count)];

            Console.WriteLine($"{currPhrase} {currEvent} {currAuthor} – {currCity}.");
        }
    }
}
