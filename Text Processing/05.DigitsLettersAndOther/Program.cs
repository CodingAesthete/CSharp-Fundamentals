using System;
using System.Collections.Generic;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> other = new List<char>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];
                if (char.IsDigit(curr))
                {
                    digits.Add(curr);
                    input=input.Remove(i, 1);
                    i--;
                }
                else if (char.IsLetter(curr))
                {
                    letters.Add(curr);
                    input=input.Remove(i, 1);
                    i--;
                }
                else
                {
                    other.Add(curr);
                    input=input.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine(String.Join("",digits));
            Console.WriteLine(String.Join("", letters));
            Console.WriteLine(String.Join("", other));
        }
    }
}
