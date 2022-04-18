using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> inputer = input.Split().ToList();

                if (inputer.Count == 2)
                {
                    int num = int.Parse(inputer[1]);

                    if (inputer[0] == "Add")
                    {
                        nums.Add(num);
                    }
                    else
                    {
                        if (num < 0 || num > nums.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        nums.RemoveAt(num);
                    }
                }
                else
                {
                    if (inputer[0] == "Insert")
                    {
                        int num = int.Parse(inputer[1]);
                        int index = int.Parse(inputer[2]);
                        if (index < 0 || index > nums.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.Insert(index, num);
                        }
                    }
                    else
                    {
                        if (inputer[1] == "left")
                        {
                            int times = int.Parse(inputer[2]);
                            for (int i = 0; i < times; i++)
                            {
                                int firstNum = nums[0];
                                nums.RemoveAt(0);
                                nums.Add(firstNum);
                            }
                        }
                        else
                        {
                            int times = int.Parse(inputer[2]);
                            for (int i = 0; i < times; i++)
                            {
                                int lastNum = nums[nums.Count - 1];
                                nums.RemoveAt(nums.Count - 1);
                                nums.Insert(0, lastNum);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ",nums));
        }
    }
}
