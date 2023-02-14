using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class MergingLists
    {
        static void Main()
        {
            List<double> input1 = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();
            List<double> input2 = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();

            List<double> output = new List<double>(input1.Count + input2.Count);

            int limit = SmallerCountList(input1, input2) * 2;


            for (int i = 0; i < limit; i++)
            {
                if (i % 2 == 0)
                {
                    output.Add(input1[0]);
                    input1.RemoveAt(0);
                }
                else
                {
                    output.Add(input2[0]);
                    input2.RemoveAt(0);
                }
            }

            if (input1.Count > input2.Count)
            {
                for (int i = 0; i < input1.Count - input2.Count; i++)
                {
                    output.Add(input1[input2.Count + i]);
                }
            }
            else
            {
                for (int i = 0; i < input2.Count - input1.Count; i++)
                {
                    output.Add(input2[input1.Count + i]);
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }

        static int SmallerCountList(List<double> a, List<double> b)
        {
            int smallerList = 0;
            if (a.Count < b.Count)
            {
                smallerList = a.Count;
            }
            else
            {
                smallerList = b.Count;
            }
            return smallerList;
        }
    }
}
