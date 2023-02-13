using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace RageQuit
{
    class RageQuit
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<char> symbols = new List<char>();

            string pattern = @"([^\d]+)([0-9]+)";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string matchString = match.Value.ToString();
                string countOfRepetitionsString = null;
                for (int i = 0; i < matchString.Length; i++)
                {
                    if (char.GetNumericValue(matchString[i]) >= 0 && char.GetNumericValue(matchString[i]) <= 9)
                    {
                        countOfRepetitionsString += matchString[i];
                    }
                }
                int countOfRepetitions = Convert.ToInt32(countOfRepetitionsString);

                

                for (int i = 0; i < countOfRepetitions; i++)
                {
                    sb.Append(match.Value.ToString().Remove(matchString.Length - countOfRepetitionsString.Length, countOfRepetitionsString.Length).ToUpper());
                }
            }

            string output = sb.ToString();

            foreach (char symbol in output)
            {
                if (!symbols.Contains(symbol))
                {
                    symbols.Add(symbol);
                }
            }
            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(output);
        }
    }
}
