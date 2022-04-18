using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> topics = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(":");

                if (command[0] == "Add")
                {
                    bool check = true;
                    for (int i = 0; i < topics.Count; i++)
                    {
                        if (topics[i] == command[1])
                        {
                            check = false;
                        }
                    }
                    if (check == true)
                    {
                        topics.Add(command[1]);
                    }
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) < 0 || int.Parse(command[2]) > topics.Count)
                    {
                        continue;
                    }
                    else
                    {
                        bool check = true;
                        for (int i = 0; i < topics.Count; i++)
                        {
                            if (topics[i] == command[1])
                            {
                                check = false;
                            }
                        }
                        if (check == true)
                        {
                            topics.Insert(int.Parse(command[2]), command[1]);
                        }
                    }

                }
                else if (command[0] == "Remove")
                {
                    for (int i = 0; i < topics.Count; i++)
                    {
                        if (topics[i] == command[1])
                        {
                            topics.RemoveAt(i);
                            i--;
                        }
                        else if (topics[i] == ((command[1]) + "-Exercise"))
                        {
                            topics.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (command[0] == "Swap")
                {
                    int index1 = topics.IndexOf(command[1]);
                    int index2 = topics.IndexOf(command[2]);
                    if (index1 != -1 && index2 != -1)
                    {
                        topics[index1] = command[2];
                        topics[index2] = command[1];
                        if (topics.Contains(command[1] + "-Exercise"))
                        {
                            topics.RemoveAt(index1 + 1);
                            int index = topics.IndexOf(command[1]);
                            topics.Insert(index + 1, (command[1] + "-Exercise"));
                        }
                        if (topics.Contains((command[2]) + "-Exercise"))
                        {
                            topics.RemoveAt(index2 + 1);
                            int index = topics.IndexOf(command[2]);
                            topics.Insert(index + 1, (command[2] + "-Exercise"));
                        }
                    }
                }
                else if (command[0] == "Exercise")
                {
                    bool check = true;

                    if (topics.Contains(command[1]))
                    {
                        int index1 = topics.FindIndex(x => x == command[1]);
                        for (int i = 0; i < topics.Count; i++)
                        {
                            if (topics[i] == (command[1] + "-Exercise"))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check == true)
                        {
                            topics.Insert(index1 + 1, command[1] + "-Exercise");
                        }
                    }
                    else
                    {
                        topics.Add(command[1]);
                        topics.Add($"{command[1]}-Exercise");
                    }
                }
            }
            for (int i = 1; i <= topics.Count; i++)
            {
                Console.WriteLine($"{i}." + String.Join(" ", topics[i - 1]));
            }
        }
    }
}
