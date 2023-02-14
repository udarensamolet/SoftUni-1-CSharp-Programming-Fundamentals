using System;
using System.Linq;


namespace Train
{
    class Train
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] passengers = new int[n];
            int allPassengers = 0;
            for (int i = 0; i < n; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                allPassengers += passengers[i];
            }
            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(allPassengers);
        }
    }
}
