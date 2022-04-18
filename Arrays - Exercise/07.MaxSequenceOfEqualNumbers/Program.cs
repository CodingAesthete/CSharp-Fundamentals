using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int num = 0;
            int max = 1;
            int maxRow = 1;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    maxRow++;
                    if (maxRow>max)
                    {
                        max = maxRow;
                        num = nums[i];
                    }
                }
                else
                {
                    maxRow = 1;
                }
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
