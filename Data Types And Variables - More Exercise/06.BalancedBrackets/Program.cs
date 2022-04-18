using System;
using System.Collections.Generic;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool check = false;
            int count = 0;
            int openingBrackets = 0;
            int closingBrackets = 0;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openingBrackets++;
                    check = true;
                    count++;
                }
                else if (input == ")")
                {
                    closingBrackets++;
                    if (check == false)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    count = 0;
                    check = false;
                }

                if (count == 2 )
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }

            if (openingBrackets!=closingBrackets)
            {
                Console.WriteLine("UNBALANCED");
                return;
            }

            Console.WriteLine("BALANCED");
        }
    }
}
