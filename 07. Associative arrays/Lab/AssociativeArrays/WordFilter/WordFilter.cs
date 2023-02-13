using System;
using System.Linq;

namespace WordFilter
{
    class WordFilter
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n.Length % 2 == 0)
                .ToArray();

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
