using System;
using System.Linq;
using System.Collections.Generic;

namespace TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> digits = new List<int>();
            List<char> nonDigits = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int digit = (int)Char.GetNumericValue(input[i]);
                    digits.Add(digit);
                }
                else
                {
                    nonDigits.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }

            string nonDigitsString = string.Join("", nonDigits);
            string output = null;

            string newElement = null;
            int startIndex = 0;
            int length = 0;
            for (int i = 0; i < digits.Count / 2; i++)
            {
                if (i == 0)
                {
                    length = takeList[0];
                }
                else
                {
                    startIndex += (skipList[i - 1] + takeList[i - 1]);
                    length = takeList[i];
                }

                if (startIndex >= 0 && startIndex < nonDigitsString.Length)
                {
                    if (startIndex + length >= nonDigitsString.Length)
                    {
                        length = nonDigitsString.Length - startIndex;
                    }
                    newElement = nonDigitsString.Substring(startIndex, length);
                }
               
                output += newElement;
            }

            Console.WriteLine(output);

        }
    }
}
