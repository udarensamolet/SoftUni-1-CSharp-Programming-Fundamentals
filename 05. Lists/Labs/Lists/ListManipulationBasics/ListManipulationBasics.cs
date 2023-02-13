using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class ListManipulationBasics
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commands[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", input));
                    break;
                }
                else if (commands[0] == "Add")
                {
                    input = Add(input, Convert.ToInt32(commands[1]));
                }
                else if (commands[0] == "Remove")
                {
                    input = Remove(input, Convert.ToInt32(commands[1]));
                }
                else if (commands[0] == "RemoveAt")
                {
                    input = RemoveAt(input, Convert.ToInt32(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    input = Insert(input, Convert.ToInt32(commands[2]), Convert.ToInt32(commands[1]));
                }
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
