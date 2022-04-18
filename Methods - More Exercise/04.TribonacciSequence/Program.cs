using System;
using System.Collections.Generic;
using System.Numerics;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Tribonacci(num);
        }

        private static void Tribonacci(int num)
        {
            BigInteger num1 = 1;
            BigInteger num2 = 1;
            BigInteger num3 = 2;
            List<BigInteger> nums = new List<BigInteger>() { num1, num2, num3 };

            if (num < 4)
            {
                if (num == 1)
                {
                    Console.WriteLine(num1);
                }
                else if (num == 2)
                {
                    Console.WriteLine($"{num1} {num2}");
                }
                else
                {
                    Console.WriteLine($"{num1} {num2} {num3}");
                }
            }
            else
            {
                NumOver3(num, nums);
            }
        }

        private static void NumOver3(int num, List<BigInteger> nums)
        {
            for (int i = 3; i < num; i++)
            {
                BigInteger currNum = nums[i - 1] + nums[i - 2] + nums[i - 3];
                nums.Add(currNum);
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
