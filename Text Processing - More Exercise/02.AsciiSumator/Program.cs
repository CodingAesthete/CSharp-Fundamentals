using System;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            int num = (int)input;
            char input2 = char.Parse(Console.ReadLine());
            int num2 = (int)input2;
            string word = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                int num3 = (int)letter;
                if (num3 > num && num3 < num2)
                {
                    sum += num3;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
