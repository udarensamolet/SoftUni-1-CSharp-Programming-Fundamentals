using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens[0] == "3:1")
                {
                    break;
                }

                string command = tokens[0];

                if (command == "merge")
                {
                    int startIndex = Convert.ToInt32(tokens[1]);
                    int endIndex = Convert.ToInt32(tokens[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex >= input.Count)
                    {
                        startIndex = input.Count - 1;
                    }

                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }
                    else if (endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }

                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        input[startIndex] += input[i];
                    }
                    input.RemoveRange(startIndex + 1, endIndex - startIndex);
                }
                else if (command == "divide")
                {
                    int index = Convert.ToInt32(tokens[1]);
                    int partitions = Convert.ToInt32(tokens[2]);

                    string elementToBePartitioned = input[index];

                    List<string> listToBeAdded = new List<string>();
                    if (elementToBePartitioned.Length % partitions == 0)
                    {
                        int newElementsLength = elementToBePartitioned.Length / partitions;
                        for (int i = 0; i < elementToBePartitioned.Length; i += newElementsLength)
                        {
                            string newElement = elementToBePartitioned.Substring(i, newElementsLength);
                            listToBeAdded.Add(newElement);
                        }
                    }
                    else
                    {
                        int newElementsLength = elementToBePartitioned.Length / partitions;
                        int lastNewElementLength = elementToBePartitioned.Length - newElementsLength * (partitions - 1);
                        for (int i = 0; i < elementToBePartitioned.Length - lastNewElementLength; i += newElementsLength)
                        {
                            string newElement = elementToBePartitioned.Substring(i, newElementsLength);
                            listToBeAdded.Add(newElement);
                        }
                        string lastNewElement = elementToBePartitioned.Substring(elementToBePartitioned.Length - lastNewElementLength, lastNewElementLength);
                        listToBeAdded.Add(lastNewElement);
                    }
                    input.RemoveAt(index);
                    input.InsertRange(index, listToBeAdded);
                }
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
