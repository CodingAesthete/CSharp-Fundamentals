using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = Console.ReadLine().Split().ToList();
            fruits = fruits.Where(x => x.Length % 2 == 0).ToList();
            Console.WriteLine(String.Join(Environment.NewLine,fruits));
        }
    }
}
