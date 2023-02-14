using System;
using System.Linq;

namespace ArrayRotation
{
    class ArrayRotation
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int movedElement = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = movedElement;
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
