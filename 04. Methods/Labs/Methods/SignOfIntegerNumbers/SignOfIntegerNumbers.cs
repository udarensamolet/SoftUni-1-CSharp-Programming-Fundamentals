using System;

namespace SignOfIntegerNumbers
{
    class SignOfIntegerNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(DefineSign(input));
        }

        static string DefineSign(int n)
        {
            string result = null;
            if (n == 0)
            {
                result = $"The number {n} is zero. ";
            }
            else if (n > 0)
            {
                result = $"The number {n} is positive. ";
            }
            else
            {
                result = $"The number {n} is negative. "; ;
            }
            return result;
        }
    }
}
