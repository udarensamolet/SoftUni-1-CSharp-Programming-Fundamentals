using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double, int> realNumbersCount = new SortedDictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!realNumbersCount.ContainsKey(input[i]))
                {
                    realNumbersCount.Add(input[i], 1);
                }
                else
                {
                    realNumbersCount[input[i]]++;
                }
            }

            foreach (var realNumber in realNumbersCount)
            {
                Console.WriteLine($"{realNumber.Key} -> {realNumber.Value}");
            }
        }
    }
}
