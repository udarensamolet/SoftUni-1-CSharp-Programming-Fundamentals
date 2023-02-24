using System;

namespace RefactoringPrimeChecker
{
    class RefactoringPrimeChecker
    {
        static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int startNumber = 2; startNumber <= endNumber; startNumber++)
            {
                string prime = "true";

                for (int divider = 2; divider < startNumber; divider++)
                {
                    if (startNumber % divider == 0)
                    {
                        prime = "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", startNumber, prime);
            }
        }
    }
}
