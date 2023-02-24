using System;
using System.Linq;

namespace RepeatStrings
{
    class ProgRepeatStringsram
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string output = null;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    output += input[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
