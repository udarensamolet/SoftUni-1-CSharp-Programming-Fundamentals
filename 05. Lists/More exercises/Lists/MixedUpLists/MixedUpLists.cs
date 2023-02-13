using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class MixedUpLists
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> mergedList = new List<int>();
            List<int> resultList = new List<int>();

            if (firstList.Count > secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    mergedList.Add(firstList[i]);
                    mergedList.Add(secondList[secondList.Count - 1 - i]);
                }

                int numberFirst = firstList[firstList.Count - 2];
                int numberSecond = firstList[firstList.Count - 1];

                int limitFirst = Math.Min(numberFirst, numberSecond);
                int limitSecond = Math.Max(numberFirst, numberSecond);

                for (int i = 0; i < mergedList.Count; i++)
                {
                    if (mergedList[i] > limitFirst && mergedList[i] < limitSecond)
                    {
                        resultList.Add(mergedList[i]);
                    }
                }
            }
            else
            {
                secondList.Reverse();
                for (int i = 0; i < firstList.Count; i++)
                {
                    mergedList.Add(firstList[i]);
                    mergedList.Add(secondList[i]);
                }

                int numberFirst = secondList[secondList.Count - 2];
                int numberSecond = secondList[secondList.Count - 1];

                int limitFirst = Math.Min(numberFirst, numberSecond);
                int limitSecond = Math.Max(numberFirst, numberSecond);

                for (int i = 0; i < mergedList.Count; i++)
                {
                    if (mergedList[i] > limitFirst && mergedList[i] < limitSecond)
                    {
                        resultList.Add(mergedList[i]);
                    }
                }

            }
            resultList.Sort();

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
