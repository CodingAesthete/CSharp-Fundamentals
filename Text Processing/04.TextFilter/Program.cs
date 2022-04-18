using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var word in input)
            {
                text=text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
