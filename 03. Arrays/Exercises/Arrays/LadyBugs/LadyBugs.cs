using System;
using System.Linq;

namespace LadyBugs
{
    class LadyBugs
    {
        static void Main()
        {
            int fieldLength = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldLength];

            for (int i = 0; i < field.Length; i++)
            {
                field[i] = 0;
            }

            for (int i = 0; i < field.Length; i++)
            {
                foreach (int position in input)
                {
                    if (i == position)
                    {
                        field[i] = 1;
                    }
                }
            }

            bool print = false;

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                int bugStartIndex = int.Parse(command[0]);
                string direction = command[1];
                int indexToMove = int.Parse(command[2]);

                if (bugStartIndex >= 0 && bugStartIndex < field.Length)
                {
                    if (field[bugStartIndex] == 1)
                    {
                        field[bugStartIndex] = 0;
                        if (direction == "right")
                        {
                            if (bugStartIndex + indexToMove < field.Length && bugStartIndex + indexToMove >= 0)
                            {
                                for (int i = bugStartIndex + indexToMove; i < field.Length; i += indexToMove)
                                {
                                    if (field[i] == 0)
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                            //print = true;
                        }
                        if (direction == "left")
                        {
                            if ((bugStartIndex - indexToMove >= 0) && (bugStartIndex - indexToMove < field.Length))
                            {
                                for (int i = bugStartIndex - indexToMove; i >= 0; i -= indexToMove)
                                {
                                    if (field[i] == 0)
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                            //print = true;
                        }
                    }
                }
            }
            // if (print == true)
            ////{
            Console.WriteLine($"{string.Join(" ", field)}");
            //  }
        }
    }
}
