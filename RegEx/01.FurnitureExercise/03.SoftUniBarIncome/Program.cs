using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main()
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%([^|$%.]+)?<(?<product>\w+)>([^|$%.]+)?\|(?<count>\d+)\|(?<price>([^|$%.]+)?\d+(\.\d+)?)\$";
            Regex regex = new Regex(pattern);
            string pattern2 = @"([^\d.]+)";
            Regex regex2 = new Regex(pattern2);
            string name;
            string product;
            int count;
            string prise;
            double price;
            string input;
            double sum = 0;
            double total = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    name = match.Groups["name"].Value;
                    product = match.Groups["product"].Value;
                    count = int.Parse(match.Groups["count"].Value);
                    prise = match.Groups["price"].Value;
                    prise = Regex.Replace(prise, pattern2, "");
                    price = double.Parse(prise);
                    sum = count * price;
                    Console.WriteLine($"{name}: {product} - {sum:F2}");
                    total += sum;
                }
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
