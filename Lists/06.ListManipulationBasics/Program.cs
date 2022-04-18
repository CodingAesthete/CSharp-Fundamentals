using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> inputer = input.Split().ToList();
                string action = inputer[0];
                int num = int.Parse(inputer[1]);

                if (action == "Add")
                {
                    nums.Add(num);
                }
                else if (action == "Remove")
                {
                    nums.Remove(num);
                }
                else if (action == "RemoveAt")
                {
                    nums.RemoveAt(num);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(inputer[2]);
                    nums.Insert(index, num);
                }
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
