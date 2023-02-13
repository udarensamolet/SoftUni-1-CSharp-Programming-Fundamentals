using System;

namespace ASCIISimulator
{
    class ASCIISimulator
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int valueFirstChar = (int)firstChar;
            int valueSecondChar = (int)secondChar;
            int minValueChar = Math.Min(valueFirstChar, valueSecondChar);
            int maxValueChar = Math.Max(valueFirstChar, valueSecondChar);

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] > minValueChar && (int)input[i] < maxValueChar)
                {
                    sum += (int)input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
