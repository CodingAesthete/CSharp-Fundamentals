using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            RectangleArea(num1, num2);
        }

        private static void RectangleArea(double num1, double num2)
        {
            double area = num1 * num2;
            Console.WriteLine(area);
        }
    }
}
