using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurencies
{
    class OddOccurencies
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> oddOccurencies = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!oddOccurencies.ContainsKey(input[i]))
                {
                    oddOccurencies.Add(input[i], 1);
                }
                else
                {
                    oddOccurencies[input[i]]++;
                }
            }

            foreach (var word in oddOccurencies)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
