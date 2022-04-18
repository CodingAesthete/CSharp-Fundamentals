using System;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[50];
            int num = int.Parse(Console.ReadLine());

            nums[0] = 1;
            nums[1] = 1;

            if (num>2)
            {
                for (int i = 2; i < num; i++)
                {
                    nums[i] = nums[i - 1] + nums[i - 2];
                }
            }

            Console.WriteLine(nums[num-1]);
        }
    }
}
