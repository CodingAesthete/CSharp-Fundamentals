using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            ClosestToCenterPoint(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void ClosestToCenterPoint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double sum1 = FirstPair(x1, y1, x2, y2);
            double sum2 = SecondPair(x3, y3, x4, y4);

            if (sum1 >= sum2)
            {
                Result(x1, y1, x2, y2);
            }
            else
            {
                Result(x3, y3, x4, y4);
            }
        }

        private static void Result(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1)+Math.Abs(y1)<=Math.Abs(x2)+Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        private static double SecondPair(double x3, double y3, double x4, double y4)
        {
            return Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4);
        }

        private static double FirstPair(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(x1) + Math.Abs(y1) +Math.Abs(x2) + Math.Abs(y2);
        }
    }
}
