using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonyms
{
    class WordSynonyms
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                if (!synonyms.ContainsKey(input1))
                {
                    synonyms.Add(input1, new List<string>());
                    synonyms[input1].Add(input2);
                }
                else
                {
                    synonyms[input1].Add(input2);
                }
            }
            foreach (var synonym in synonyms)
            {
                Console.WriteLine($"{synonym.Key} - {string.Join(", ", synonym.Value)}");
            }
        }
    }
}
