using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            Console.WriteLine(1+" "+ 1);
            ulong[] nums = { 1, 1 };
            for (int i = 0; i < num-2; i++)
            {
                ulong[] arr = new ulong[nums.Length + 1];
                
                for (int j = 0; j < nums.Length+1; j++)
                {
                    if (j == 0)
                    {
                        arr[0] = 1;
                        continue;
                    }
                    if (j==nums.Length)
                    {
                        arr[nums.Length] = 1;
                        continue;
                    }

                    arr[j] = nums[j-1] + nums[j];
                }
                Console.WriteLine(String.Join(" ",arr));
                nums = arr;
            }
        }
    }
}
