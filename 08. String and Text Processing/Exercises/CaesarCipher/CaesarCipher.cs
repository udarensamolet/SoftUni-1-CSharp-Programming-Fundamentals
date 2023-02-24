using System;

namespace CaesarCipher
{
    class CaesarCipher
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = null;

            for (int i = 0; i < input.Length; i++)
            {
                output += Convert.ToChar(input[i] + 3);
            }
            Console.WriteLine(output);
        }
    }
}
