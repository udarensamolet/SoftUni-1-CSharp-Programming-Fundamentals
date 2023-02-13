using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace PostOffice
{
    class PostOffice
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<char, int> lettersLength = new Dictionary<char, int>();

            string firstPart = input[0];
            string patterFirstPart = @"(\$[A-Z]+\$)|(\#[A-Z]+\#)|(\*[A-Z]+\*)|(\%[A-Z]+\%)|(\&[A-Z]+\&)";
            Regex regexFirstPart = new Regex(patterFirstPart);
            Match matchFirstPart = regexFirstPart.Match(firstPart);
            string lettersCapital = null;
            for (int i = 1; i < matchFirstPart.Value.Length - 1; i++)
            {
                lettersCapital += matchFirstPart.Value[i];
            }
    
            string secondPart = input[1];
            string patternSecondPart = @"[0-9][0-9]:[0-9][0-9]";
            Regex regexSecondPart = new Regex(patternSecondPart);
            MatchCollection matchesSecondPart = regexSecondPart.Matches(secondPart);

            for (int i = 0; i < lettersCapital.Length; i++)
            {
                foreach (Match matchSecondPart in matchesSecondPart)
                {
                    int[] tokens = matchSecondPart.Value.Split(':', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    int letterCode = tokens[0];
                    int wordLength = tokens[1] + 1;

                    if (lettersCapital[i] == Convert.ToChar(letterCode))
                    {
                        if (!lettersLength.ContainsKey(lettersCapital[i]))
                        {
                            lettersLength.Add(lettersCapital[i], wordLength);
                        }
                    }

                }
            }

            string thirdPart = input[2];
            string patternThirdPart = @"(?<word>\S+)";
            Regex regexThirdPart = new Regex(patternThirdPart);
            MatchCollection matchesThirdPart = regexThirdPart.Matches(thirdPart);

            foreach (var pair in lettersLength)
            {
                foreach (Match matchThirdPart in matchesThirdPart)
                {
                    string matchWord = matchThirdPart.Groups["word"].Value;
                    string newMatchWord = null;

                    for (int i = 0; i < matchWord.Length; i++)
                    {
                        if ((int)matchWord[i] >= 0 && (int)matchWord[i] <= 254 && (int)matchWord[i] != 32)
                        {
                            newMatchWord += matchWord[i];
                        }
                    }

                    if (pair.Key == newMatchWord[0] && pair.Value == newMatchWord.Length && pair.Value <= 20)
                    {
                        Console.WriteLine(newMatchWord);
                        break;
                    }
                }
            }
        }
    }
}
