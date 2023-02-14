using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main()
        {
            /* First working way
             * string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] output = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[input.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", output));
            */

            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string oldElement = null;

            for (int i = 0; i < input.Length / 2; i++)
            {
                oldElement = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = oldElement;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
