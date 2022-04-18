using System;
using System.Linq;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int part = nums.Length / 4;
            int[] firstArr = new int[nums.Length/2];
            int[] secondArr = new int[nums.Length / 2];

            for (int i = 0+part; i < nums.Length-part; i++)
            {
                firstArr[i - part] = nums[i];
            }

            for (int i = 0; i <  part; i++)
            {
                secondArr[i] = nums[i];
            }

            for (int i = nums.Length-part-1; i < nums.Length; i++)
            {
                secondArr[i+part+1] = nums[i];
                Console.WriteLine(i);
            }
        }
    }
}
