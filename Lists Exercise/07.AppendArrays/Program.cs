using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split("|").ToList();
            List<string> neu = new List<string>();
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                var halt = arr[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                neu.AddRange(halt);
            }
            Console.WriteLine(String.Join(" ", neu));
        }
    }
}
