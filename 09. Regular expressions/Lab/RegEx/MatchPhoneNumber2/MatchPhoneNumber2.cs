using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber2
{
    class MatchPhoneNumber2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\+359([ -])2\1[0-9]{3}\1[0-9]{4}\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            string[] matchesArr = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchesArr));
        }
    }
}
