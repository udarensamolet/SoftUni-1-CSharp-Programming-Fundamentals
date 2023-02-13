using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SantasSecretHelper
{
    class SantasSecretHelper
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    char newValueChar = Convert.ToChar((int)input[i] - key);
                    sb.Append(newValueChar);
                }
                string message = sb.ToString();

                string pattern = @"(?<name>@[A-Za-z]+)(?<character>[^@\-!:>]*)(?<behaviour>\![G]\!)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(message);

                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value.ToString();
                    name = name.Remove(0, 1);

                    Console.WriteLine(name);
                }
            }
        }
    }
}
