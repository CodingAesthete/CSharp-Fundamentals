using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            string input = Console.ReadLine().ToUpper();
            string[] words = input.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            int[] nums = new int[matches.Count];
            int count = 0;
            foreach (Match match in matches)
            {
                nums[count] = int.Parse(match.Value.ToString());
                count++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int digit = nums[i];
                for (int j = 0; j < digit; j++)
                {
                    result.Append(words[i].ToString());
                }
            }
            char[] used = result.ToString().Distinct().ToArray();
            Console.WriteLine($"Unique symbols used: {used.Length}");
            Console.WriteLine(result.ToString());
        }
    }
}
