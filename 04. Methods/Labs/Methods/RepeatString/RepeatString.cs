using System;

namespace RepeatString
{
    class RepeatString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatStr(n, input));
        }

        static string RepeatStr(int n, string str)
        {
            string result = null;
            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
