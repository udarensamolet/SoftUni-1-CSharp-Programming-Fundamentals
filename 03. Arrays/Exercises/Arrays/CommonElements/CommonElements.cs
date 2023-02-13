using System;
using System.Linq;

namespace CommonElements
{
    class CommonElements
    {
        static void Main()
        {
            string[] arrayFirst = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] arraySecond = Console.ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < arraySecond.Length; i++)
            {
                for (int j = 0; j < arrayFirst.Length; j++)
                {
                    if (arraySecond[i] == arrayFirst[j])
                    {
                        Console.Write($"{arraySecond[i]} ");
                    }
                }
            }
        }
    }
}
