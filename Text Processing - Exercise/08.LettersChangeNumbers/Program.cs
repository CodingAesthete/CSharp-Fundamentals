using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<double> numeros = new List<double>();
            foreach (var word in input)
            {
                StringBuilder number = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsDigit(word[i]))
                    {
                        number.Append(word[i].ToString());
                    }
                }
                double num = double.Parse(number.ToString());
                char first = word.First();
                if (char.IsUpper(first))
                {
                    double pos = ((int)first) - 64;
                    num /= pos;
                }
                else
                {
                    int pos = ((int)first) - 96;
                    num *= pos;
                }
                char last = word.Last();
                if (char.IsUpper(last))
                {
                    double pos = ((int)last) - 64;
                    num -= pos;
                }
                else
                {
                    int pos = ((int)last) - 96;
                    num += pos;
                }
                numeros.Add(num);
            }
            double sum = 0;
            foreach (var item in numeros)
            {
                sum += item;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
