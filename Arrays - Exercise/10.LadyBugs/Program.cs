using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];

            int[] bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < bugIndexes.Length; i++)
            {
                if (bugIndexes[i] >= 0 && bugIndexes[i] < field.Length)
                {
                    field[bugIndexes[i]] = 1;
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "end")
                {
                    break;
                }
                string[] command = input.Split();
                int startIndex = int.Parse(command[0]);
                int flyLength = int.Parse(command[2]);

                if (startIndex >= 0 && startIndex < fieldSize && field[startIndex] == 1)
                {
                    field[startIndex] = 0;
                    if (flyLength == 0)
                    {
                        field[startIndex] = 1;
                        continue;
                    }
                }
                else if (startIndex < 0 || startIndex >= fieldSize || field[startIndex] == 0)
                {
                    continue;
                }
                if (command[1] == "left")
                {
                    while (startIndex - flyLength >= 0 && startIndex - flyLength < fieldSize)
                    {
                        if (field[startIndex - flyLength] == 0)
                        {
                            field[startIndex - flyLength] = 1;
                            break;
                        }
                        else
                        {
                            startIndex -= flyLength;
                        }

                    }
                }
                else if (command[1] == "right")
                {
                    while ((startIndex + flyLength >= 0 && startIndex + flyLength < fieldSize))
                    {
                        if (field[startIndex + flyLength] == 0)
                        {
                            field[startIndex + flyLength] = 1;
                            break;
                        }
                        else
                        {
                            startIndex += flyLength;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
