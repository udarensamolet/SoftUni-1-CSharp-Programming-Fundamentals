using System;

namespace PasswordValidator
{
    class PasswordValidator
    {
        static void Main()
        {
            PrintResult(Console.ReadLine());
        }

        static bool CheckCharacters(string str)
        {
            bool isValid = true;
            if (!(str.Length >= 6 && str.Length <= 10))
            {
                isValid = false;
            }
            return isValid;
        }

        static bool CheckLettersAndDigits(string str)
        {
            bool isValid = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (!((Convert.ToInt32(str[i]) >= 48 && Convert.ToInt32(str[i]) <= 57) || (Convert.ToInt32(str[i]) >= 65 && Convert.ToInt32(str[i]) <= 90)
                    || (Convert.ToInt32(str[i]) >= 97 && Convert.ToInt32(str[i]) <= 122)))
                {
                    isValid = false;
                }
            }
            return isValid;
        }
        static bool CheckDigitsCount(string str)
        {
            bool isValid = true;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Convert.ToInt32(str[i]) >= 48 && Convert.ToInt32(str[i]) <= 57)
                {
                    count++;
                }
            }
            if (count < 2)
            {
                isValid = false;
            }
            return isValid;
        }

        static void PrintResult(string input)
        {
            if (CheckCharacters(input) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (CheckLettersAndDigits(input) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (CheckDigitsCount(input) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CheckCharacters(input) == true && CheckLettersAndDigits(input) == true && CheckDigitsCount(input) == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
