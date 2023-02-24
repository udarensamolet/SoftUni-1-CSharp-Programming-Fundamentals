using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToList();

            if (input.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }

            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
