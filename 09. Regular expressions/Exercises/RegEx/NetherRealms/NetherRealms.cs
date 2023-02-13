using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class NetherRealms
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine()
                .Split(new string[] { "," , ", ", " ", " ," }, StringSplitOptions.RemoveEmptyEntries) 
                .ToArray();

            List<Demon> demons = new List<Demon>();

            string patternHealth = @"[^0-9\+\-\*\/\.\s]";
            Regex regexHealth = new Regex(patternHealth);
            string patternDamage = @"(?<number>([\+|\-])?[0-9]+(\.[0-9]+)?)";
            Regex regexDamage = new Regex(patternDamage);
            string patternDamageArithmetics = @"[*\/]";
            Regex regexDamageArithmetics = new Regex(patternDamageArithmetics);


            foreach (string input in inputs)
            {
                MatchCollection matchesHealth = Regex.Matches(input, patternHealth);
                int strength = 0;
                foreach (Match matchHealth in matchesHealth)
                {
                    strength += Convert.ToChar(matchHealth.Value);
                }

                MatchCollection matchesDamage = Regex.Matches(input, patternDamage);
                double damage = 0;
                foreach (Match matchDamage in matchesDamage)
                {
                    damage += Convert.ToDouble(matchDamage.Groups["number"].Value);
                }

                MatchCollection matchesDamageArithmetics = Regex.Matches(input, patternDamageArithmetics);
                List<char> arithmeticOperations = new List<char>();
                foreach (Match match in matchesDamageArithmetics)
                {
                    arithmeticOperations.Add(Convert.ToChar(match.Value));
                }


                for (int i = 0; i < arithmeticOperations.Count; i++)
                {
                    if (arithmeticOperations[i] == '*')
                    {
                        damage *= 2;
                    }
                    else if (arithmeticOperations[i] == '/')
                    {
                        if (damage != 0)
                        {
                            damage /= 2;
                        }
                    }
                }
                Demon demon = new Demon(input, strength, damage);
                demons.Add(demon);
            }
            
            foreach (var demon in demons.OrderBy(x => x.Name))
            {
                
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");              
            }
        }
    }
}
