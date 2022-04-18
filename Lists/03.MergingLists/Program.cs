using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (nums1.Count<=nums2.Count)
            {
                int index = 0;
                for (int i = 0; i < nums1.Count; i++)
                {
                    nums2.Insert(index, nums1[i]);
                    index+=2;
                }
                Console.WriteLine(String.Join(" ", nums2));
            }
            if (nums1.Count > nums2.Count)
            {
                int index = 1;
                for (int i = 0; i < nums2.Count; i++)
                {
                    nums1.Insert(index, nums2[i]);
                    index += 2; 
                }
                Console.WriteLine(String.Join(" ", nums1));
            }

        }
    }
}
