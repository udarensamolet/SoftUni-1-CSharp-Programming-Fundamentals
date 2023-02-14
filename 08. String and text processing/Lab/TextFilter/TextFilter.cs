using System;
using System.Linq;

namespace TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (input.Contains(word))
                {
                    input = input.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(input);
            
        }
    }
}
