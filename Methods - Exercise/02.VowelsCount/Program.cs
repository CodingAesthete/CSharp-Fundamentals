using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            VowelsCounter(word);
        }

        private static void VowelsCounter(string word)
        {
            char [] volews = {'a', 'A', 'o', 'O', 'e', 'E', 'u', 'U', 'i', 'I' };
            int countVolews = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (volews.Contains(word[i]))
                {
                    countVolews++;
                }
            }

            Console.WriteLine(countVolews);
        }
    }
}
