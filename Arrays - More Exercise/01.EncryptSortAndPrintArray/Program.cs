using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            int[] nums = new int[num];

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;
                char[] volews = {'A', 'a', 'o', 'O', 'e', 'E', 'U', 'u', 'i', 'I' };

                for (int j = 0; j < name.Length; j++)
                {
                    bool check = true;
                    char currChar = name[j];

                    for (int k = 0; k < volews.Length; k++)
                    {
                        if (volews[k]==currChar)
                        {
                            sum += ((int)currChar) * name.Length;
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        sum += ((int)currChar) / name.Length;
                    }
                }
                nums[i] = sum;
            }

            Console.WriteLine(String.Join("\n",nums.OrderBy(x=>x)));
        }
    }
}
