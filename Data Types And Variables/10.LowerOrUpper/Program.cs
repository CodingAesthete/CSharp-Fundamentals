using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            int numValue = (int)letter;

            if (numValue >= 65 && numValue <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (numValue >= 97 && numValue <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
