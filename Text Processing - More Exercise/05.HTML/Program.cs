using System;
using System.Collections.Generic;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string h1 = Console.ReadLine();
            string article = Console.ReadLine();
            List<string> divs = new List<string>();
            string div;
            while ((div = Console.ReadLine()) != "end of comments")
            {
                divs.Add(div);
            }
            Console.WriteLine("<h1>");
            Console.WriteLine($"   {h1}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"   {article}");
            Console.WriteLine("</article>");
            foreach (var item in divs)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"   {item}");
                Console.WriteLine("</div>");
            }
        }
    }
}
