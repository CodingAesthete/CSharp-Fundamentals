using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            string text = Console.ReadLine();
            var matches = regex.Matches(text);
            Console.WriteLine(String.Join(", ", matches));
        }
    }
}
