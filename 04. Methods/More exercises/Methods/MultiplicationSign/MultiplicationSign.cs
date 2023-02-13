using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (CheckZero(num1, num2, num3))
            {
                Console.WriteLine("zero");
            }
            else if (CheckSign(num1, num2, num3))
            {
                Console.WriteLine("positive");
            }
            else if (!CheckSign(num1, num2, num3))
            {
                Console.WriteLine("negative");

            }
        }
        static bool CheckZero(double a, double b, double c)
        {
            bool isZero = false;
            if (a == 0 || b == 0 || c == 0)
            {
                isZero = true;
            }
            return isZero;
        }
        static bool CheckSign(double a, double b, double c)
        {
            bool isPositive = false;
            if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0))
            {
                isPositive = true;
            }
            return isPositive;
        }
    }
}
