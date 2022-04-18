using System;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int middle = arr.Length / 2; //0 1 2 3 4 5 6
            double sum1 = 0;
            double sum2 = 0;
            double newsum1 = 0;
            double newsum2 = 0;
            for (int i = 0; i < middle; i++)
            {
                sum1 += arr[i];
                if (arr[i] == 0)
                {
                    sum1 *= 0.8;
                }
                newsum1 = sum1;

            }
            for (int i = arr.Length - 1; i > middle; i--)
            {
                sum2 += arr[i];
                if (arr[i] == 0)
                {
                    sum2 *= 0.8;
                }
                newsum2 = sum2;
            }
            if (sum1 < sum2)
            {
                Console.WriteLine($"The winner is left with total time: {newsum1}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {newsum2}");
            }
        }
    }
}
