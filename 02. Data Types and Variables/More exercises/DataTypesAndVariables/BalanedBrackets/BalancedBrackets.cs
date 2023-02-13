using System;

namespace BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            string input = null;
            bool opened = false;
            bool closed = false;
            int counterOpeningBrackets = 0;

            for (int i = 0; i < lines; i++)
            {
                input = Console.ReadLine();
                if (input == "(")
                {
                    counterOpeningBrackets++;
                    if (counterOpeningBrackets > 1)
                    {
                        opened = false;
                    }
                    else
                    {
                        opened = true;
                        closed = false;
                    }
                }

                if (input == ")" && opened == true)
                {
                    counterOpeningBrackets = 0;
                    opened = false;
                    closed = true;
                }
                else if (input == ")" && opened == false)
                {
                    counterOpeningBrackets = 0;
                    closed = false;
                }


            }


            if (opened == false && closed == true)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
