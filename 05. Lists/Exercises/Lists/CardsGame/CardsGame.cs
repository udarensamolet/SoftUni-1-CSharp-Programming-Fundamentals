using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class AppendArrays
    {
        static void Main()
        {
            List<int> playerOne = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> playerTwo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                for (int i = 0; i < Math.Min(playerOne.Count, playerTwo.Count); i++)
                {
                    if (playerOne[0] == playerTwo[0])
                    {
                        playerOne.RemoveAt(0);
                        playerTwo.RemoveAt(0);
                    }
                    else if (playerOne[0] > playerTwo[0])
                    {
                        playerOne.Add(playerOne[0]);
                        playerOne.Add(playerTwo[0]);
                        playerOne.RemoveAt(0);
                        playerTwo.RemoveAt(0);
                    }
                    else if (playerOne[0] < playerTwo[0])
                    {
                        playerTwo.Add(playerTwo[0]);
                        playerTwo.Add(playerOne[0]);
                        playerTwo.RemoveAt(0);
                        playerOne.RemoveAt(0);
                    }
                }
            }

            int sum = 0;
            string winner = null;

            if (playerOne.Count > playerTwo.Count)
            {
                winner = "First";
                for (int i = 0; i < playerOne.Count; i++)
                {
                    sum += playerOne[i];
                }
            }
            else if (playerOne.Count < playerTwo.Count)
            {
                winner = "Second";
                for (int i = 0; i < playerTwo.Count; i++)
                {
                    sum += playerTwo[i];
                }
            }

            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }
    }
}
