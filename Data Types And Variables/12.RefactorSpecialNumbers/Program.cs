using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= count; i++)
            {
                bool check = false;
                int sum = 0;
                int currDigit = i;
                while (currDigit > 0)
                {
                    sum += currDigit % 10;
                    currDigit /= 10;
                }
                check = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, check);
            }

        }
    }
}
