using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double number = 0;
            double totalResult = 0;
    
            for (int i = 0; i < input.Length; i++)
            {
                double resultPresent = 0;
                char firstLetter = Convert.ToChar(input[i][0]);
                char lastLetter = Convert.ToChar(input[i][input[i].Length - 1]);
                number = Convert.ToDouble(input[i].Substring(1, input[i].Length - 2));


                if (char.IsUpper(firstLetter))
                {
                    int index = char.ToUpper(firstLetter) - 64;
                    resultPresent = number / index;

                }
                else if (char.IsLower(firstLetter))
                {
                    int index = char.ToUpper(firstLetter) - 64;
                    resultPresent = number * index;
                }

                if (char.IsUpper(lastLetter))
                {
                    int index = char.ToUpper(lastLetter) - 64;
                    resultPresent -= index;

                }
                else if (char.IsLower(lastLetter))
                {
                    int index = char.ToUpper(lastLetter) - 64;
                    resultPresent += index;
                }
                totalResult += resultPresent;
            }
            Console.WriteLine($"{totalResult:f2}");
        }
    }
}
