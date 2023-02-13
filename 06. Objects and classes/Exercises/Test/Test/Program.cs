using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string test = "sd,asd,asd,asd,asd,asd";
            string[] blah = test.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}
