using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"[^\S][A-Za-z0-9]+[\.|\-|_]?[A-Za-z0-9]*@[A-Za-z\-]+(?:\.[A-Za-z]+)+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}
