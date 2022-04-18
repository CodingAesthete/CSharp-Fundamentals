using System;
using System.Linq;

namespace _05.TopItegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                bool check = true;
                int currNum = nums[i];

                for (int j = i+1; j < nums.Length; j++)
                {
                    if (currNum<=nums[j])
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    Console.Write($"{currNum} ");
                }
            }
        }
    }
}
