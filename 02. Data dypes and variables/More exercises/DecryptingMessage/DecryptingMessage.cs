using System;

namespace DecryptingMessages
{
    class DecryptingMessages
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            char input;
            string output = null;

            for (int i = 0; i < lines; i++)
            {
                input = char.Parse(Console.ReadLine());
                output += (char)(input + key);
            }
            Console.WriteLine(output);
        }
    }
}