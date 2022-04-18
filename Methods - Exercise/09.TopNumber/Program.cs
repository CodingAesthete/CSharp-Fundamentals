using System;
using System.Collections.Generic;
using System.Text;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TopNumber(num);
        }

        private static void TopNumber(int num)
        {

            for (int i = 1; i <= num; i++)
            {
                bool check1 = DivisibleBy8(i);
                bool check2 = AtLeast1OddDigit(i);
                
                if (check1 && check2)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool AtLeast1OddDigit(int num)
        {
            while (num != 0)
            {
                int currDigit = num % 10;

                if (currDigit%2==1)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }

        private static bool DivisibleBy8(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
