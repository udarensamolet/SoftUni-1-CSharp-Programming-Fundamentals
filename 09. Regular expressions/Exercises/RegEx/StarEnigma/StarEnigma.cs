using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class StarEnigma
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string patternStar = @"[STARstar]";
                string patternDecryptedMessage = @"[^@,\-!:>]*?\@(?<planetName>[A-Z][a-z]+)[^@,\-!:>]*?\:[^@,\-!:>]*?(?<planetPopulation>[0-9]+)[^@,\!:>]*?\!(?<attackType>[AD])\![^@,\!:>]*?\-\>(?<soldierCount>[0-9]+)[^@,\-!:>]";
                Regex regexStar = new Regex(patternStar);
                MatchCollection matches = regexStar.Matches(encryptedMessage);
                int count = matches.Count;
                string decodedMessage = null;

                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    decodedMessage += Convert.ToChar((encryptedMessage[j] - count));
                }
                Regex regexDecryptedMessage = new Regex(patternDecryptedMessage);
                MatchCollection matchesMessage = regexDecryptedMessage.Matches(decodedMessage);
                string planetName = null;
                int planetPopulation = 0;
                char attackType = '\0';
                int soldierCount = 0;

                foreach (Match match in matchesMessage)
                {
                    planetName = match.Groups["planetName"].Value;
                    planetPopulation = Convert.ToInt32(match.Groups["planetPopulation"].Value);
                    attackType = Convert.ToChar(match.Groups["attackType"].Value);
                    soldierCount = Convert.ToInt32(match.Groups["soldierCount"].Value);
                }

                if (attackType == 'A')
                {
                    attackedPlanets.Add(planetName);
                }
                else if (attackType == 'D')
                {
                    destroyedPlanets.Add(planetName);
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var attackedPlanet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {attackedPlanet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var destroyedPlanet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }
    }
}
