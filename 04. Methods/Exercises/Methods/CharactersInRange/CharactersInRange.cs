using System;

namespace CharactersInRange
{
    class CharactersInRange
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            PrintRange(a, b);
        }

        static void PrintRange(char a, char b)
        {
            for (int i = MinChar(a, b) + 1; i < MaxChar(a, b); i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }

        static int MinChar(char a, char b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int MaxChar(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
