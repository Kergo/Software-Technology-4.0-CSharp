using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{

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

        public void Edit(string newContent)
        {
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

    public class Program
    {
        public static void Main(string[] args)
        {
            
            string[] tockens = Console.ReadLine().Split(", ");
            string title = tockens[0];
            string content = tockens[1];
            string author = tockens[2];

            var article = new Article(title, content, author);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(": ");
                string command = input[0];
                
                if (command == "Edit")
                {
                    string newContent = input[1];

                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = input[1];

                    article.ChangeAuthor(newAuthor);
                }
                else if(command == "Rename")
                {
                    string newTitle = input[1];

                    article.Rename(newTitle);
                }
            }
            System.Console.WriteLine(article);
        }
    }
}
