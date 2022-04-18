using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> neu = new List<int>();
            List<int> extra = new List<int>();
            List<int> neu2 = new List<int>();
            int length = Math.Min(nums1.Count, nums2.Count);
            int stop = Math.Max(nums1.Count, nums2.Count);
            for (int i = 0; i < length; i++)
            {
                neu.Add(nums1[i]);
                neu.Add(nums2[nums2.Count - 1 - i]);
            }
            if (nums2.Count > nums1.Count)
            {
                for (int i = nums2.Count - nums1.Count - 1; i >= 0; i--)
                {
                    extra.Add(nums2[i]);
                }
            }
            else if (nums1.Count > nums2.Count)
            {
                for (int i = nums2.Count; i < nums1.Count; i++)
                {
                    extra.Add(nums1[i]);
                }
            }
            extra.Sort();
            neu.Sort();
            for (int i = 0; i < neu.Count; i++)
            {
                if (neu[i] > extra[0] && neu[i] < extra[1])
                {
                    neu2.Add(neu[i]);
                }
            }
            Console.WriteLine(String.Join(" ", neu2));
        }
    }
}
