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
            int[] firstArr;
            int[] secondArr = new int[nums.Length / 2];
            int[] firstPar = new int[secondArr.Length / 2];
            int[] secondPar = new int[secondArr.Length / 2];

            for (int i = 0; i < part; i++)
            {
                firstPar[i] = nums[i];
            }

            Array.Reverse(firstPar);

            for (int i = part; i < 3*part; i++)
            {
                secondArr[i-part] = nums[i];
            }

            for (int i = 3*part; i < nums.Length; i++)
            {
                secondPar[i - 3 * part] = nums[i];
            }

            Array.Reverse(secondPar);

            firstArr = firstPar.Concat(secondPar).ToArray();

            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write($"{firstArr[i]+secondArr[i]} ");
            }
        }
    }
}
