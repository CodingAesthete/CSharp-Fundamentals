using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            var input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    sb.Append(input[i]);

                }
                if (i == input.Length - 2)
                {
                    sb.Append(input[i + 1]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
