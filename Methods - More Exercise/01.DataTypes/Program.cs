using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type=="string")
            {
                string word = Console.ReadLine();
                Output(word);
            }
            else if (type == "int")
            {
                int num = int.Parse(Console.ReadLine());
                Output(num);
            }
            else if (type=="real")
            {
                double num = double.Parse(Console.ReadLine());
                Output(num);
            }
        }

        private static void Output(double num)
        {
            Console.WriteLine($"{(num*1.5):f2}");
        }

        private static void Output(int num)
        {
            Console.WriteLine(num * 2); 
        }

        private static void Output(string word)
        {
            Console.WriteLine($"${word}$");
        }
    }
}
