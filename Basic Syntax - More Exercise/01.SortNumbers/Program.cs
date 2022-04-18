using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double maxNum = Math.Max(firstNum, Math.Max(secondNum, thirdNum));
            double minNum = Math.Min(firstNum, Math.Min(secondNum, thirdNum));
            double middleNum = (firstNum + secondNum + thirdNum) - (maxNum + minNum);

            Console.WriteLine(maxNum);
            Console.WriteLine(middleNum);
            Console.WriteLine(minNum);
        }
    }
}
