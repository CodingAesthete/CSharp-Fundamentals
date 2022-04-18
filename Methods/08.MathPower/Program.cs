using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            MathPower(num, power);
        }

        private static void MathPower(double num, double power)
        {
            Console.WriteLine(Math.Pow(num,power));
        }
    }
}
