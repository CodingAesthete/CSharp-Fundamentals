using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];

                for (int j = i+1; j < nums.Length; j++)
                {
                    if (currNum + nums[j] == num)
                    {
                        Console.WriteLine($"{currNum} {nums[j]}");
                    }
                }
            }
        }
    }
}
