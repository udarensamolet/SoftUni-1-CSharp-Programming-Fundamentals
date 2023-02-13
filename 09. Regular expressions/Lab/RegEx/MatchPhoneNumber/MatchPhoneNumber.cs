using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\+359([ -])2\1[0-9]{3}\1[0-9]{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
