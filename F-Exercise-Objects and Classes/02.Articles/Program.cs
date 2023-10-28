/*
some title, some content, some author
3
Edit: better content
ChangeAuthor: better author
Rename: better title

Fight club, love story, Martin Scorsese
2
Edit: underground fight club that evolves into much more
ChangeAuthor: Chuck Palahniuk
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

        public void Edit (string newContent) {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
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

            string[] wholeArticle = Console.ReadLine().Split(", ");
            string title = wholeArticle[0];
            string content = wholeArticle[1];
            string author = wholeArticle[2];

            Article article = new Article(title, content, author);

            int numberOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfChanges; i++)
            {
                string[] changedArticle = Console.ReadLine().Split(": ");
                string command = changedArticle[0];
                string newArticleParts = changedArticle[1];

                if (command == "Edit")
                {
                    article.Edit(newArticleParts);

                }
                else if (command == "ChangeAuthor") 
                {
                    article.ChangeAuthor(newArticleParts);
                }
                else if (command == "Rename")
                {
                    article.Rename(newArticleParts);
                }              
            }
            Console.WriteLine(article.ToString());
        }
    }
}