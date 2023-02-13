using System;


namespace AddAndSubtract
{
    class AddAndSubtract
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(Sum(a, b), c));
        }

        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static int Subtract(int a, int b)
        {
            int diff = a - b;
            return diff;
        }
    }
}
