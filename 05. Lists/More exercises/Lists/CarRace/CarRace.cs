using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class CarRace
    {
        static void Main()
        {
            int[] times = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int middleTimes = times.Length / 2;

            double sumFirstRacer = 0;
            double sumSecondRacer = 0;

            for (int i = 0; i < middleTimes; i++)
            {
                if (times[i] != 0)
                {
                    sumFirstRacer += times[i];
                }
                else
                {
                    sumFirstRacer -= 0.2 * sumFirstRacer;
                }

            }

            for (int i = times.Length - 1; i > middleTimes; i--)
            {
                if (times[i] != 0)
                {
                    sumSecondRacer += times[i];
                }
                else
                {
                    sumSecondRacer -= 0.2 * sumSecondRacer;
                }
            }


            if (sumFirstRacer < sumSecondRacer)
            {
                Console.WriteLine($"The winner is left with total time: {sumFirstRacer}");
            }
            else if (sumFirstRacer > sumSecondRacer)
            {
                Console.WriteLine($"The winner is right with total time: {sumSecondRacer}");
            }
        }
    }
}
