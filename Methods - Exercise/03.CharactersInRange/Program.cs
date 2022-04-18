using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharactersRange(firstChar, secondChar);
        }

        private static void CharactersRange(char firstChar, char secondChar)
        {
            int max = Math.Max((int)firstChar,(int)secondChar);
            int min = Math.Min((int)firstChar, (int)secondChar);

            for (int i = min+1; i < max; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
