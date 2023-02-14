using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Race
{
    class Race
    {
        static void Main()
        {
            string[] racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> actualRacers = new Dictionary<string, int>();

            string input = Console.ReadLine();

            string patternRacerNames = @"[A-Za-z]";
            string patternRacerDistance = @"[0-9]";

            while (input != "end of race")
            {
                Regex regexRacerNames = new Regex(patternRacerNames);
                Regex regexRacerDistance = new Regex(patternRacerDistance);

                MatchCollection matchRacerNameChars = regexRacerNames.Matches(input);
                StringBuilder matchRacerName = new StringBuilder();

                foreach (Match matchRacerNameChar in matchRacerNameChars)
                {
                    matchRacerName.Append(matchRacerNameChar.Value);
                }
                foreach (var racer in racers)
                {
                    if (matchRacerName.ToString() == racer)
                    {
                        MatchCollection matchRacerDistanceDigits = regexRacerDistance.Matches(input);
                        int matchRacerDistanceSumDigits = 0;
                        foreach (Match matchRacerDistanceDigit in matchRacerDistanceDigits)
                        {
                            matchRacerDistanceSumDigits += Convert.ToInt32(matchRacerDistanceDigit.Value);
                        }
                        if (!actualRacers.ContainsKey(racer))
                        {
                            actualRacers.Add(racer, matchRacerDistanceSumDigits);
                        }
                        else
                        {
                            actualRacers[racer] += matchRacerDistanceSumDigits;
                        }
                        
                    }
                }
                input = Console.ReadLine();
            }
         
            int counter = 1;

            foreach (var racer in actualRacers.OrderByDescending(x => x.Value))
            {
                if (counter <= 3)
                {
                    switch (counter)
                    {
                        case 1:
                            Console.WriteLine($"1st place: {racer.Key}");
                            break;
                        case 2:
                            Console.WriteLine($"2nd place: {racer.Key}");
                            break;
                        case 3:
                            Console.WriteLine($"3rd place: {racer.Key}");
                            break;
                    }
                    counter++;
                }
            }
        }
    }
}
