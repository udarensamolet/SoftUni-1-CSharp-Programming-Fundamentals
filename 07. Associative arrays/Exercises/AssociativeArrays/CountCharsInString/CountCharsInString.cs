using System;
using System.Linq;
using System.Collections.Generic;

namespace CountCharsInString
{
    class CountCharsInString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> occurencies = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (!occurencies.ContainsKey(input[i]))
                    {
                        occurencies.Add(input[i], 1);
                    }
                    else
                    {
                        occurencies[input[i]]++;
                    }
                }
            }

            foreach (var character in occurencies)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
