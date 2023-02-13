using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] conditions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int specialNumber = conditions[0];
            int power = conditions[1];
            int sum = 0;

            while (list.Contains(specialNumber))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == specialNumber)
                    {
                        //OK start in range and end in range
                        if (i - power >= 0 && i + power < list.Count)
                        {
                            list.RemoveRange(i - power, (power * 2) + 1);
                        }
                        //start out of range and end out of range
                        else if (i - power < 0 && i + power >= list.Count)
                        {
                            list.RemoveRange(0, list.Count);
                        }
                        //OK start out of range and end in range
                        else if (i - power < 0 && i + power < list.Count)
                        {
                            list.RemoveRange(0, power + i + 1);
                        }
                        //OK start in range and end out of range
                        else if (i - power >= 0 && i + power >= list.Count)
                        {
                            list.RemoveRange(i - power, list.Count - (i - power));
                        }

                        /*int startIndex = Math.Max(0, i - power);
                        int count = Math.Min(list.Count, (power * 2) + 1);
                        list.RemoveRange(startIndex, count);*/
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }


            //Console.WriteLine(string.Join(" ", list));


            Console.WriteLine(sum);

        }
    }
}
