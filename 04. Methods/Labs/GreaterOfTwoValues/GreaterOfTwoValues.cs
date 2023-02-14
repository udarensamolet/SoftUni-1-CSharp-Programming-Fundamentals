using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            GetType(Console.ReadLine());

        }

        static void GetType(string input)
        {
            switch (input)
            {
                case "int":
                    Console.WriteLine(MaxInt());
                    break;
                case "char":
                    Console.WriteLine(MaxChar());
                    break;
                case "string":
                    Console.WriteLine(MaxStr());
                    break;
            }
        }

        static int MaxInt()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            return (Math.Max(a, b));
        }

        static char MaxChar()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string MaxStr()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (string.Compare(a, b) == 1)
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
