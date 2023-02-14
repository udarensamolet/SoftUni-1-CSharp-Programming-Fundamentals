using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            int counter = 0;
            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (commands[0] == "end")
                {
                    if (counter > 0)
                    {
                        Console.WriteLine(string.Join(" ", input));
                    }
                    break;
                }
                else if (commands[0] == "Contains")
                {
                    ContaintsNumber(input, Convert.ToInt32(commands[1]));
                }
                else if (commands[0] == "PrintEven")
                {
                    PrintEven(input);
                }
                else if (commands[0] == "PrintOdd")
                {
                    PrintOdd(input);
                }
                else if (commands[0] == "GetSum")
                {
                    GetSum(input);
                }
                else if (commands[0] == "Filter")
                {
                    Filter(input, commands[1], Convert.ToInt32(commands[2]));
                }
                else if (commands[0] == "Add")
                {
                    input = Add(input, Convert.ToInt32(commands[1]));
                    counter++;
                }
                else if (commands[0] == "Remove")
                {
                    input = Remove(input, Convert.ToInt32(commands[1]));
                    counter++;
                }
                else if (commands[0] == "RemoveAt")
                {
                    input = RemoveAt(input, Convert.ToInt32(commands[1]));
                    counter++;
                }
                else if (commands[0] == "Insert")
                {
                    input = Insert(input, Convert.ToInt32(commands[2]), Convert.ToInt32(commands[1]));
                    counter++;
                }
            }
        }

        static void ContaintsNumber(List<int> list, int n)
        {
            if (list.Contains(n))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Console.Write($"{list[i]} ");
                }
            }
            Console.WriteLine();
        }
        static void PrintOdd(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    Console.Write($"{list[i]} ");
                }
            }
            Console.WriteLine();
        }
        static void GetSum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
        static void Filter(List<int> list, string condition, int n)
        {
            if (condition == "<")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < n)
                    {
                        Console.Write($"{list[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == ">")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > n)
                    {
                        Console.Write($"{list[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] >= n)
                    {
                        Console.Write($"{list[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= n)
                    {
                        Console.Write($"{list[i]} ");
                    }
                }
                Console.WriteLine();
            }
        }
        static List<int> Add(List<int> list, int n)
        {
            list.Add(n);
            return list;
        }
        static List<int> Remove(List<int> list, int n)
        {
            list.RemoveAll(x => x == n);
            return list;
        }
        static List<int> RemoveAt(List<int> list, int n)
        {
            list.RemoveAt(n);
            return list;
        }
        static List<int> Insert(List<int> list, int m, int n)
        {
            list.Insert(m, n);
            return list;
        }
    }
}
