using System;
using System.Linq;

namespace Articles
{
    class Articles
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string title = input[0].TrimStart();
            string content = input[1].TrimStart();
            string author = input[2].TrimStart();

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (commands[0] == "Edit")
                {
                    article.EditContent(commands[1].TrimStart());
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commands[1].TrimStart());
                }
                else if (commands[0] == "Rename")
                {
                    article.RenameArticle(commands[1].TrimStart());
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}
