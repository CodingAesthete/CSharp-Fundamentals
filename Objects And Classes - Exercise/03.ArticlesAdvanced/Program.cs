using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ArticlesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                List<string> input = Console.ReadLine().Split(", ").ToList();
                Article article = new Article(input[0], input[1], input[2]);
                Console.WriteLine(article.ToString());
            }
            string input2 = Console.ReadLine();
        }

        public class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
