using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            decimal res= DivideFactorial(num1, num2);
            Console.WriteLine($"{res:f2}");
        }

        private static decimal DivideFactorial(int num1, int num2)
        {
            decimal firstFact = 1;

            for (int i = num1; i > 0; i--)
            {
                firstFact *= i;
            }

            decimal secondFact = 1;

            for (int i = num2; i > 0; i--)
            {
                secondFact *= i;
            }

            return firstFact/secondFact;
        }
    }
}
