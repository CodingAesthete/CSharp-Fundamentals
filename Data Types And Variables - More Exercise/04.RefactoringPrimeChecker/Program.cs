using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                bool check = true;
                for (int e = 2; e < i; e++)
                {
                    if (i % e == 0)
                    {
                        check = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, check.ToString().ToLower());
            }

        }
    }
}
