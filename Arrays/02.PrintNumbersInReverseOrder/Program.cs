using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int[] arr = new int[nums];

            for (int i = 0; i < nums; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(arr);
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
