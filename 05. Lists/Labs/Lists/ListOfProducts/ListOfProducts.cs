﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class ListOfProducts
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }

        }
    }
}
