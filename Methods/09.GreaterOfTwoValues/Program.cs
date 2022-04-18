using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Compare(num1, num2);
            }
            else if (type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                Compare(str1, str2);
            }
            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                Compare(char1, char2);
            }
        }

        private static void Compare(int num1, int num2)
        {
            int res = num1.CompareTo(num2);
            if (res == 0 || res == 1)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        private static void Compare(string str1, string str2)
        {
            int res = str1.CompareTo(str2);
            if (res == 0 || res == 1)
            {
                Console.WriteLine(str1);
            }
            else
            {
                Console.WriteLine(str2);
            }
        }

        private static void Compare(char char1, char char2)
        {
            int res = char1.CompareTo(char2);
            if (res == 0 || res == 1)
            {
                Console.WriteLine(char1);
            }
            else
            {
                Console.WriteLine(char2);
            }
        }
    }
}
