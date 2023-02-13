using System;

namespace PalindromeIntegers
{
    class PalindromeIntegers
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                Console.WriteLine(PalindromeCheck(input).ToString().ToLower());
            }
        }

        static bool PalindromeCheck(string str)
        {
            bool isPalindrome = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}
