using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class ListOperations
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

                if (commands[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                else if (commands[0] == "Add")
                {
                    list.Add(Convert.ToInt32(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    if (Convert.ToInt32(commands[2]) < 0 || Convert.ToInt32(commands[2]) >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(Convert.ToInt32(commands[2]), Convert.ToInt32(commands[1]));
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (Convert.ToInt32(commands[1]) < 0 || Convert.ToInt32(commands[1]) >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(Convert.ToInt32(commands[1]));
                    }
                }
                else if (commands[0] == "Shift")
                {
                    if (commands[1] == "left")
                    {
                        for (int i = 0; i < Convert.ToInt32(commands[2]); i++)
                        {
                            int number = list[0];
                            list.RemoveAt(0);
                            list.Add(number);

                        }
                    }
                    else if (commands[1] == "right")
                    {
                        for (int i = 0; i < Convert.ToInt32(commands[2]); i++)
                        {
                            int number = list[list.Count - 1];
                            list.RemoveAt(list.Count - 1);
                            list.Insert(0, number);
                        }
                    }
                }
            }
        }
    }
}
