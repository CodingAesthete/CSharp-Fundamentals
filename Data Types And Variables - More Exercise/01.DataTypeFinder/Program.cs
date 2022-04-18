using System;
using System.Numerics;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int intValue;
            double doubleValue;
            char charValue;
            bool boolValue;

            while ((input=Console.ReadLine())!="END")
            {
                if (int.TryParse(input, out intValue))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if(double.TryParse(input, out doubleValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out boolValue))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out charValue))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else 
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
