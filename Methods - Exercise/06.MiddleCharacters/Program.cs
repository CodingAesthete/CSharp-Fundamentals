using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleFinder(word);
        }

        private static void MiddleFinder(string word)
        {
            string middle = "";

            if (word.Length % 2 == 1)
            {
                middle = ((char)word[word.Length / 2]).ToString();
            }
            else
            {
                middle += ((char)(word[word.Length / 2 - 1])).ToString();
                middle += ((char)(word[word.Length / 2])).ToString();
            }
            Console.WriteLine(middle);
        }
    }
}
