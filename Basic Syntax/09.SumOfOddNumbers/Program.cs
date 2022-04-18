using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNums = int.Parse(Console.ReadLine());
            int currNum = 1;
            int sum = 0;

            for (int i = 0; i < countNums; i++)
            {
                Console.WriteLine(currNum);
                sum += currNum;
                currNum += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
