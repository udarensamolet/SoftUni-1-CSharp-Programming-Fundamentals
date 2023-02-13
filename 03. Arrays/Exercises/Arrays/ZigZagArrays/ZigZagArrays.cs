using System;
using System.Linq;

namespace ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayFirst = new int[n];
            int[] arraySecond = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    arrayFirst[i] = input[0];
                    arraySecond[i] = input[1];
                }
                else
                {
                    arraySecond[i] = input[0];
                    arrayFirst[i] = input[1];
                }
            }

            Console.WriteLine(string.Join(" ", arrayFirst));
            Console.WriteLine(string.Join(" ", arraySecond));
        }
    }
}
