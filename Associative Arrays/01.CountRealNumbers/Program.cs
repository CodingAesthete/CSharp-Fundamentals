using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = 0;
                }
                dictionary[nums[i]]++;
            }

            foreach (var item in dictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
