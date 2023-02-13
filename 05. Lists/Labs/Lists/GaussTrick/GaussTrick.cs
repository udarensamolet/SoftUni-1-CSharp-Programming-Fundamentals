using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class GaussTrick
    {
        static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            int limit = input.Count / 2;
            for (int i = 0; i < limit; i++)
            {
                input[i] += input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
