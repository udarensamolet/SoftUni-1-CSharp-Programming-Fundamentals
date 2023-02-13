using System;
using System.Linq;

namespace TopIntegers
{
    class TopIntegers
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                bool isTop = true;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        isTop = false;
                    }
                }
                if (isTop == true)
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}
