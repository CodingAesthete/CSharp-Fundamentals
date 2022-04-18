using System;

namespace _10.MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = PositiveNum(input);
            int evenSum = SumEvenDigits(num);
            int oddSum = SumOddDigits(num);
            int multiplyDigits = Multiply(evenSum, oddSum);
            Console.WriteLine(multiplyDigits);
        }

        private static int Multiply(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }

        private static int SumOddDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int currNDigit = num % 10;
                if (currNDigit % 2 != 0)
                {
                    sum += currNDigit;
                }
                num /= 10;
            }

            return sum;
        }

        private static int SumEvenDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int currNDigit = num % 10;
                if (currNDigit%2==0)
                {
                    sum += currNDigit;
                }
                num /= 10;
            }

            return sum;
        }

        private static int PositiveNum(int num)
        {
            num = Math.Abs(num);
            return num;
        }
    }
}
