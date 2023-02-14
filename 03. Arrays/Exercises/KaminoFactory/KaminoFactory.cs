using System;
using System.Linq;
using System.Collections;

namespace KaminoFactory
{
    class KaminoFactory
    {
        static void Main()
        {
            int lengthSequences = int.Parse(Console.ReadLine());

            int sum = 0;
            int bestSum = -1;

            int sequence = 0;
            int bestSequence = -1;

            int counter = 0;
            int bestCounter = -1;

            int index = 0;
            int bestIndex = -1;

            int[] bestArr = new int[lengthSequences];

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }

                counter++;

                int[] arr = input
                    .Replace("!", " ")
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sum = 0;
                sequence = 0;
                index = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        sum += arr[i];
                        for (int j = i + 1; j < arr.Length - 1; j++)
                        {
                            if (arr[i] != arr[j])
                            {
                                break;
                            }
                            else
                            {
                                sequence++;
                                index = i;
                            }
                        }
                    }
                }

                if (sequence > bestSequence)
                {
                    bestSequence = sequence;
                    bestSum = sum;
                    bestCounter = counter;
                    bestIndex = index;
                    bestArr = arr;
                }
                else if (sequence == bestSequence)
                {
                    if (index == bestIndex)
                    {
                        if (sum > bestSum)
                        {
                            bestSequence = sequence;
                            bestSum = sum;
                            bestCounter = counter;
                            bestIndex = index;
                            bestArr = arr;
                        }
                    }
                    else if (index < bestIndex)
                    {
                        bestSequence = sequence;
                        bestSum = sum;
                        bestCounter = counter;
                        bestIndex = index;
                        bestArr = arr;
                    }
                }
            }

            if (bestSum > -1)
            {
                Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
                Console.WriteLine(string.Join(" ", bestArr));
            }
        }
    }
}
