using System;

namespace MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main()
        {
            Console.WriteLine(FindMiddleChar(Console.ReadLine()));
        }

        static string FindMiddleChar(string str)
        {
            string result = null;
            int middle = 0;

            if (str.Length % 2 != 0)
            {
                middle = (str.Length / 2);
                result = str[middle].ToString();
            }
            else
            {
                middle = str.Length / 2;
                result = str[middle - 1].ToString() + str[middle].ToString();
            }

            return result;
        }
    }
}
