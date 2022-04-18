using System;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string curr = Console.ReadLine();
                string[] nums = curr.Split(" ");
                BigInteger first=BigInteger.Parse(nums[0]);
                BigInteger second = BigInteger.Parse(nums[1]);
                BigInteger sum = 0;

                if (first > second)
                {
                    double firsto = Math.Abs((double)first);
                    while (firsto>0)
                    {
                        sum += (BigInteger)firsto % 10;
                        firsto /= 10;
                    }
                }
                else
                {
                    double secondo = Math.Abs((double)second);
                    while (secondo > 0)
                    {
                        sum += (BigInteger)secondo % 10;
                        secondo /= 10;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
