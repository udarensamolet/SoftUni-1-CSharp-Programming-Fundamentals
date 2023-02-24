using System;
using System.Text;

namespace HTML
{
    class HTML
    {
        static void Main()
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<h1>");
            sb.AppendLine($"    {title}");
            sb.AppendLine($"</h1>");

            sb.AppendLine("<article>");
            sb.AppendLine($"    {content}");
            sb.AppendLine($"</article>");


            while (true)
            {
                string comment = Console.ReadLine();
                if (comment == "end of comments")
                {
                    break;
                }

                sb.AppendLine("<div>");
                sb.AppendLine($"    {comment}");
                sb.AppendLine($"</div>");
            }

            string output = sb.ToString();
            Console.WriteLine(output);
        }
    }
}
