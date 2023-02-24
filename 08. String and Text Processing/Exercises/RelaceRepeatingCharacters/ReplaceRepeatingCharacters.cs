using System;

namespace RelaceRepeatingCharacters
{
    class RelaceRepeatingCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = null;
            char letter = '\0';

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    letter = input[i];
                }
                else
                {
                    letter = input[i];
                    output += letter;
                }
            }

            if (input[input.Length - 1] != input[input.Length - 2])
            {
                letter = input[input.Length - 1];
                output += letter;
            }
            else
            {
                output += letter;
            }
            Console.WriteLine(output);
        }
    }
}
