using System;

namespace _10.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input=Console.ReadLine())!="END")
            {
                bool check= PalindromeChecker(input);
                Console.WriteLine(check.ToString().ToLower());
            }
        }

        private static bool PalindromeChecker(string num)
        {
            bool check = true;

            if (num.Length/2==1)
            {
                for (int i = 0; i < num.Length/2; i++)
                {
                    if (num[i]!=num[num.Length-1-i])
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                for (int i = 0; i < num.Length / 2; i++)
                {
                    if (num[i] != num[num.Length - 1 - i])
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
