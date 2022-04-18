using System;
using System.Numerics;

namespace _03._ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < nums; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
