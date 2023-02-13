using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class MatchDates
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<day>[0-9]{2})([.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }            
        }
    }
}
