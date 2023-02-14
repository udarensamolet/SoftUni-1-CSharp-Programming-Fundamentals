using System;

namespace MathOperations
{
    class MathOperations
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(GetResult(a, b, @operator));
        }

        static double GetResult(double a, double b, char c)
        {
            double result = 0;
            switch (c)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
            }
            return result;
        }
    }
}
