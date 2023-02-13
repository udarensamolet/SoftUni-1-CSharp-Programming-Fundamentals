using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles2
{
    class Articles2
    {
        static void Main()
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string title = input[0].TrimStart();
                string content = input[1].TrimStart();
                string author = input[2].TrimStart();

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string criteria = Console.ReadLine();
            List<Article> sortedArticles = new List<Article>();

            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}
