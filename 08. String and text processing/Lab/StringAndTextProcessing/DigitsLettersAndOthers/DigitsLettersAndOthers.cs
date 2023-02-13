using System;

namespace TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string digits = null;
            string letters = null;
            string chars = null;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    letters += input[i];
                }
                else if (Char.IsDigit(input[i]))
                {
                    digits += input[i];
                }
                else
                {
                    chars += input[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);

        }
    }
}
