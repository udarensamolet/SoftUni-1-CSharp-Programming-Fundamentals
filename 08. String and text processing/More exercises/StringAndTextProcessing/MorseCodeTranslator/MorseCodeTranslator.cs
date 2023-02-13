using System;
using System.Linq;
using System.Text;

namespace MorseCodeTranslator
{
    class MorseCodeTranslator
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(CheckLetter(input[i]));
            }
            Console.WriteLine(sb.ToString());
        }

        static char CheckLetter(string input)
        {
            char letter = ' ';
            switch (input)
            {
                case ".-":
                    letter = 'A';
                    break;
                case "-...":
                    letter = 'B';
                    break;
                case "-.-.":
                    letter = 'C';
                    break;
                case "-..":
                    letter = 'D';
                    break;
                case ".":
                    letter = 'E';
                    break;
                case "..-.":
                    letter = 'F';
                    break;
                case "--.":
                    letter = 'G';
                    break;
                case "....":
                    letter = 'H';
                    break;
                case "..":
                    letter = 'I';
                    break;
                case ".---":
                    letter = 'J';
                    break;
                case "-.-":
                    letter = 'K';
                    break;
                case ".-..":
                    letter = 'L';
                    break;
                case "--":
                    letter = 'M';
                    break;
                case "-.":
                    letter = 'N';
                    break;
                case "---":
                    letter = 'O';
                    break;
                case ".--.":
                    letter = 'P';
                    break;
                case "--.-":
                    letter = 'Q';
                    break;
                case ".-.":
                    letter = 'R';
                    break;
                case "...":
                    letter = 'S';
                    break;
                case "-":
                    letter = 'T';
                    break;
                case "..-":
                    letter = 'U';
                    break;
                case "...-":
                    letter = 'V';
                    break;
                case ".--":
                    letter = 'W';
                    break;
                case "-..-":
                    letter = 'X';
                    break;
                case "-.--":
                    letter = 'Y';
                    break;
                case "--..":
                    letter = 'Z';
                    break;
                case "|":
                    letter = ' ';
                    break;
            }
            return letter;
        }
    }
}
