using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class WinningTicket
    {
        static void Main()
        {
            string[] tickets = Console.ReadLine()
                .Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < tickets.Length; i++)
            {
                string ticket = tickets[i];
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else
                {
                    string pattern = @"[\#]{6,}|[\$]{6,}|[\@]{6,}|[\^]{6,}";
                    Regex regex = new Regex(pattern);

                    string ticketRightSide = ticket.Substring(0, 10);
                    string ticketLeftSide = ticket.Substring(10, 10);

                    Match matchesRightSide = regex.Match(ticketRightSide);
                    Match matchesLeftSide = regex.Match(ticketLeftSide);

                    if (matchesRightSide.Success && matchesLeftSide.Success)
                    {
                        if (matchesRightSide.ToString()[0] == matchesLeftSide.ToString()[0])
                        {
                            int matchesRightSideLength = matchesRightSide.Length;
                            int matchesLeftSideLength = matchesLeftSide.Length;
                            int length = Math.Min(matchesRightSideLength, matchesLeftSideLength);

                            if (length >= 6 && length <= 9)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {length}{matchesRightSide.ToString()[0]}");
                            }
                            else if (length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {length}{matchesRightSide.ToString()[0]} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - no match");
                            }
                        }
                        else
                        {
                           Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
