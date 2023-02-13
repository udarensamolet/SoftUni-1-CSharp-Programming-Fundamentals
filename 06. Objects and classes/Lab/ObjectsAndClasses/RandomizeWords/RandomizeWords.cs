using System;
using System.Linq;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random rand = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                string temp = input[i];
                int randNumber = rand.Next(input.Length);
                input[i] = input[randNumber];
                input[randNumber] = temp;
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
