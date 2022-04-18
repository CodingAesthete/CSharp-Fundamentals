using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = SumTwoNums(num1, num2);
            int result = SubtractTwoNums(sum, num3);
            Console.WriteLine(result);
        }

        private static int SubtractTwoNums(int sum, int num3)
        {
            return sum - num3;
        }

        private static int SumTwoNums(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
