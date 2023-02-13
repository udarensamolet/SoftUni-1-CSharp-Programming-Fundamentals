using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class AppendsArrays
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<int> output = new List<int>(input.Count);
            for (int i = input.Count - 1; i >= 0; i--)
            {
                List<int> strings = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                output.AddRange(strings);

            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
