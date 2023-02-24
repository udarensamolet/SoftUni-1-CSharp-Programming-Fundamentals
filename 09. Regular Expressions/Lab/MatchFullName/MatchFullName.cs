using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}
