using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            foreach (var e in arr2)
            {
                foreach (var el in arr1)
                {
                    if (el==e)
                    {
                        Console.Write($"{el} ");
                    }
                }
            }
        }
    }
}
