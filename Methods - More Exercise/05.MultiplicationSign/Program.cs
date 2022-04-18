using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            SignFinder(num1, num2, num3);
        }

        private static void SignFinder(double num1, double num2, double num3)
        {
            int negativeNums = 0;

            if (num1==0 || num2==0 || num3==0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (num1<0)
                {
                    negativeNums++;
                }
                if (num2<0)
                {
                    negativeNums++;
                }
                if(num3<0)
                {
                    negativeNums++;
                }

                if (negativeNums==1 ||negativeNums==3)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }
        }
    }
}
