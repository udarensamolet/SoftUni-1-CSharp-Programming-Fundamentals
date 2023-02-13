using System;
using System.Linq;

namespace LongestIncreasingSubsequenceLIS
{
    class Program
    {
        static void Main()
        {
            int[] sequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] currentLIS = new int[sequence.Length];
            int[] maxLIS = new int[sequence.Length];
            int maxLISLength = int.MinValue;
            int currentLISLength = 0;
            int startPosition = 0;
            
            //iterating the whole input sequence
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                currentLIS[i] = sequence[i];
                int counter = 0;
                int additionalCounter = 0;
                for (int j = i + additionalCounter + 1; j < sequence.Length; j++)
                {
                    if (sequence[i] < sequence[j] && sequence[j] > currentLIS[counter])
                    {
                        counter++;
                        currentLIS[counter] = sequence[j];
                    }

                    //does this make any sensce at all???
                    if (j == sequence.Length - 1)
                    {
                        //currentLIS = currentLIS.Where(element => element.ToString() != null).ToArray();
                        if (counter > maxLISLength)
                        {
                            maxLISLength = counter;
                            maxLIS = currentLIS;
                        }
                    }
                }
                if (additionalCounter < sequence.Length)
                {
                    additionalCounter++;
                    i--;
                }
            }
        }
    }
}
