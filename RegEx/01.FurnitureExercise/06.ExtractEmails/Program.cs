using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\s([0-9A-Za-z]+(_|-|\.)*[0-9A-Za-z]+@[a-z]+-*[a-z]+(\.[a-z]+)+)";
            Regex regex = new Regex(pattern);
            var matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
