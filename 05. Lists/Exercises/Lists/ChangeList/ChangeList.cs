using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
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
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                else if (commands[0] == "Delete")
                {
                    list.RemoveAll(x => x == Convert.ToInt32(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    list.Insert(Convert.ToInt32(commands[2]), Convert.ToInt32(commands[1]));
                }
            }
        }
    }
}
