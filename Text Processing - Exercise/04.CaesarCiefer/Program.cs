using System;
using System.Text;

namespace _04.CaesarCiefer
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    int num = input[i] + 3;
                    char letter = (char)(num);
                    result.Append(letter);
                }
                else
                {
                    string low = input[i].ToString();
                    int lows = int.Parse(low);
                    lows = lows + 3;
                    string final = lows.ToString();
                    result.Append(final);
                }
            }
            Console.WriteLine(result);
        }
    }
}
