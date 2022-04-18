using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int add = 0;
            int current = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int num = int.Parse(input[i + 1].ToString());
                    for (int j = i + 1; j < i + 1 + num + add; j++)
                    {
                        if (num == 0)
                        {
                            break;
                        }
                        if (j > input.Length - 1)
                        {
                            break;
                        }
                        if (char.IsLetterOrDigit(input[j]))
                        {
                            num--;
                            input = input.Remove(j, 1);
                            j--;
                            current = j;
                        }
                        else if (input[j] == '>')
                        {
                            num--;
                            j--;
                            add++;
                        }
                    }
                }

            }
            while (add != 0)
            {
                add--;
                if (current + 1 > input.Length - 1)
                {
                    break;
                }
                else
                {
                    input = input.Remove(current + 1, 1);
                }

            }
            Console.WriteLine(input);
        }
    }
}
