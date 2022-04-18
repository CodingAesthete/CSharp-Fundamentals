using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Calculator(num1, action, num2);
        }

        private static void Calculator(double num1, char action, double num2)
        {
            if (action=='+')
            {
                Console.WriteLine(num1+num2);
            }
            else if (action=='-')
            {
                Console.WriteLine(num1-num2);
            }
            else if (action == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            else if (action == '/')
            {
                Console.WriteLine(num1 / num2);
            }
        }
    }
}
