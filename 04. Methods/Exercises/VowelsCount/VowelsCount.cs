using System;

namespace VowelsCount
{
    class VowelsCount
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(CountVowels(input));
        }

        static int CountVowels(string str)
        {
            int countVowels = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'
                    || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    countVowels++;
                }
            }
            return countVowels;
        }
    }
}
