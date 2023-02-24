using System;
using System.Linq;

namespace ValidUsernames
{
    class ValidUsernames 
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            bool isValid = false;

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Length >= 3 && usernames[i].Length <= 16)
                {
                    for (int j = 0; j < usernames[i].Length; j++)
                    {
                        if (char.IsLetter(usernames[i][j]) || char.IsDigit(usernames[i][j])
                            || usernames[i][j] == '-' || usernames[i][j] == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(usernames[i]);
                }
                isValid = false;
            }
        }
    }
}
