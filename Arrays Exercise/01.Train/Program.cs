using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int [] nums = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ", nums));
            Console.WriteLine(nums.Sum());
        }
    }
}
