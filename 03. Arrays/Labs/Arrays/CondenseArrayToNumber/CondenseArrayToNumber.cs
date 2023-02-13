using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[input.Length - 1];
            int counter = 0;

            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
            }
            else
            {
                while (counter < input.Length - 1)
                {
                    condensed = new int[input.Length - 1];
                    for (int i = 0; i < condensed.Length; i++)
                    {

                        condensed[i] = input[i] + input[i + 1];
                        input[i] = condensed[i];
                    }
                    counter++;
                }
                Console.WriteLine(condensed[0]);
            }


        }
    }
}
