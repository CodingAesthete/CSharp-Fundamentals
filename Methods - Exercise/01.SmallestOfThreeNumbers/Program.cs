using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            MinNum(firstNum, secondnum, thirdNum);
        }

        private static void MinNum(int firstNum, int secondnum, int thirdNum)
        {
            int result = Math.Min(firstNum, Math.Min(secondnum, thirdNum));
            Console.WriteLine(result); ;
        }
    }
}
