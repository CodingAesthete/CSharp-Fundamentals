using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string message = "";

            string two = "abc";
            string three = "def";
            string four = "ghi";
            string five = "jkl";
            string six = "mno";
            string seven = "pqrs";
            string eight = "tuv";
            string nine = "wxyz";
            string zero = " ";

            for (int i = 0; i < num; i++)
            {
                string currNum = Console.ReadLine();
                char firstDigit = currNum[0];

                if (firstDigit == '2')
                {
                    message += two[currNum.Length - 1];
                }
                else if (firstDigit == '3')
                {
                    message += three[currNum.Length - 1];
                }
                else if (firstDigit == '4')
                {
                    message += four[currNum.Length - 1];
                }
                else if (firstDigit == '5')
                {
                    message += five[currNum.Length - 1];
                }
                else if (firstDigit == '6')
                {
                    message += six[currNum.Length - 1];
                }
                else if (firstDigit == '7')
                {
                    message += seven[currNum.Length - 1];
                }
                else if (firstDigit == '8')
                {
                    message += eight[currNum.Length - 1];
                }
                else if (firstDigit == '9')
                {
                    message += nine[currNum.Length - 1];
                }
                else if (firstDigit == '0')
                {
                    message += zero[currNum.Length - 1];
                }
            }

            Console.WriteLine(message);
        }
    }
}
