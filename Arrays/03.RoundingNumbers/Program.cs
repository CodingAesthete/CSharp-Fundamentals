using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                double currNum = nums[i];
                if (currNum==-0)
                {
                    currNum = 0;
                }
                Console.WriteLine($"{currNum} => {Math.Round(currNum, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
