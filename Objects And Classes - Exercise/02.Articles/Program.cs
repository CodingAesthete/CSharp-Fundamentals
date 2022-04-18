using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            Article article = new Article(input[0], input[1], input[2]);
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                List<string> list = Console.ReadLine().Split(": ").ToList();
                Changes(article,list);
            }
            Console.WriteLine(article.ToString());
        }

        private static void Changes(Article article,List<string> list)
        {
            if (list[0]=="Edit")
            {
                article.Content = list[1];
            }
            else if (list[0]=="ChangeAuthor")
            {
                article.Author = list[1];
            }
            else if (list[0]=="Rename")
            {
                article.Title = list[1];
            }
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
