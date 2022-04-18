using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string searched = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            while (word.Contains(searched))
            {
                int startIndex = word.IndexOf(searched);
                word=word.Remove(startIndex, searched.Length);
            }

            Console.WriteLine(word);
        }
    }
}
