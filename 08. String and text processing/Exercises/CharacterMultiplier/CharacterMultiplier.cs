using System;
using System.Linq;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string input1 = input[0];
            string input2 = input[1];

            Console.WriteLine(CharacterMultiplying(input1, input2));
        }

        static int CharacterMultiplying(string str1, string str2)
        {
            int result = 0;
            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    result += str1[i] * str2[i];
                }
            }
            else if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    result += str1[i] * str2[i];
                }
                for (int i = str2.Length; i < str1.Length; i++)
                {
                    result += str1[i];
                }
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    result += str1[i] * str2[i];
                }
                for (int i = str1.Length; i < str2.Length; i++)
                {
                    result += str2[i];
                }
            }
            return result;
        }
    }
}
