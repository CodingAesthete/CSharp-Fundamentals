using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int add2 = 0;
            if (input == "0" || num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                string cur = input[i].ToString();
                int cure = int.Parse(cur);
                int rel = cure * num;
                rel += add2;
                int add = rel % 10;
                add2 = rel / 10;
                result.Insert(0, add);
                if (i == 0)
                {
                    if (add2 != 0)
                    {
                        result.Insert(0, add2);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
