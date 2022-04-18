using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> list = input.Split().ToList();

                if (list.Count == 2)
                {
                    int num = int.Parse(list[1]);
                    nums = nums.Where(s => s != num).ToList();
                }
                else
                {
                    int index = int.Parse(list[2]);
                    int num = int.Parse(list[1]);
                    nums.Insert(index, num);
                }
            }

            Console.WriteLine(String.Join(" ",nums));
        }
    }
}
