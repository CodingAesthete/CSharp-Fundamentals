using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"\@{6,}|\#{6,}|\${6,}|\^{6,}";
            Regex regex = new Regex(pattern);
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string left = ticket.Substring(0, 10);
                    string right = ticket.Substring(10);
                    var match = regex.Match(left);
                    var match2 = regex.Match(right);
                    string m = match.ToString();
                    string m2 = match2.ToString();
                    int min = Math.Min(match.Length, match2.Length);
                    var leftmatch = m.Substring(0, min);
                    var rightmatch = m2.Substring(0, min);
                    if (!match.Success || !match2.Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                    else
                    {
                        if (leftmatch.Equals(rightmatch))
                        {
                            if (leftmatch.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {leftmatch.Length}{leftmatch.Substring(0, 1)} Jackpot!");
                            }
                            else if (leftmatch.Length >= 6 && leftmatch.Length <= 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {leftmatch.Length}{leftmatch.Substring(0, 1)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                }
            }
        }
    }
}
