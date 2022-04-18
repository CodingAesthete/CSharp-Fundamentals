using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int e = 1; e <= num; e++)
            {
                string strNum = e.ToString();
                int sum = 0;

                for (int i = 0; i < strNum.Length; i++)
                {
                    sum += int.Parse(strNum[i].ToString());
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{e} -> True");
                }
                else
                {
                    Console.WriteLine($"{e} -> False");
                }
            }

        }
    }
}
