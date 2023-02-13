using System;

namespace Substring
{
    class Substring
    {
        static void Main()
        {
            string stringToBeRemoved = Console.ReadLine();
            string stringToBeModified = Console.ReadLine();

            int startIndex = stringToBeModified.IndexOf(stringToBeRemoved);
            int count = stringToBeRemoved.Length;

            string modifiedString = null;

            while (startIndex > -1)
            {
                stringToBeModified = stringToBeModified.Remove(startIndex, count);
                startIndex = stringToBeModified.IndexOf(stringToBeRemoved);
            }
            Console.WriteLine(stringToBeModified);
        }
    }
}
