/*
2
Science, planets, Bill
Article, content, Johnny

3
title1, C, author1
title2, B, author2
title3, A, author3

 */

using System.ComponentModel.DataAnnotations;

namespace _03.Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfChanges = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();


            for (int i = 0; i < numberOfChanges; i++)
            {
                string[] wholeArticle = Console.ReadLine().Split(", ");
                string title = wholeArticle[0];
                string content = wholeArticle[1];
                string author = wholeArticle[2];
                Article article = new Article(title, content, author);
                articles.Add(article);

            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}