using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Repeater(input, count);
        }

        private static void Repeater(string input, int count)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(input);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
