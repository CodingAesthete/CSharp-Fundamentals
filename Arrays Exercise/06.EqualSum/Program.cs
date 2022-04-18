using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];
                int sum1 = 0;
                int sum2 = 0;

                for (int j = i+1; j < nums.Length; j++)
                {
                    sum1 += nums[j];
                }

                for (int k = 0; k < i; k++)
                {
                    sum2 += nums[k];
                }

                if (sum1==sum2)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
