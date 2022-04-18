using System;

namespace _01.ExtractPersonalInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string name = "";
            int age = 0;
            for (int i = 0; i < count; i++)
            {

                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < input.Length; j++)
                {

                    if (input[j].Contains("|")) // abc@Vanio|k
                    {
                        int start = input[j].IndexOf("@");
                        int finish = input[j].IndexOf("|");
                        name = input[j].Substring(start + 1, finish - start - 1);

                    }
                    if (input[j].Contains("#"))
                    {
                        int start = input[j].IndexOf("#");
                        int finish = input[j].IndexOf("*");
                        age = int.Parse(input[j].Substring(start + 1, finish - start - 1));

                    }

                }
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
