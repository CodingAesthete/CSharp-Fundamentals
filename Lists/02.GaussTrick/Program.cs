using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            if (nums.Count%2!=0)
            {
                for (int i = 0; i < nums.Count / 2; i++)
                {
                    nums[i] += nums[nums.Count - 1];
                    nums.RemoveAt(nums.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i <= nums.Count / 2; i++)
                {
                    nums[i] += nums[nums.Count - 1];
                    nums.RemoveAt(nums.Count - 1);
                }
            }

            Console.WriteLine(String.Join(" ",nums));
        }
    }
}
