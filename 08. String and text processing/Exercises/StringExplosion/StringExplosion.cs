using System;
using System.Text;

namespace StringExplosion
{
    class StringExplosion
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool areThereBombs = true;
            int storedStrength = 0;

            while (areThereBombs)
            {
                int strength = 0;
                int bombPosition = 0;
                int startPosition = 0;

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == '>' && Char.IsDigit(input[i + 1]))
                    {
                        bombPosition = i;
                        startPosition = i + 1;
                        strength = Convert.ToInt32(Char.GetNumericValue(input[i + 1])) + storedStrength;
                        if (bombPosition + strength >= input.Length)
                        {
                            strength = input.Length - bombPosition - 1;
                        }
                        string stringToBeDeleted = input.Substring(startPosition, strength);

                        if (!stringToBeDeleted.Contains('>'))
                        {
                            if (bombPosition + strength >= input.Length)
                            {
                                strength = input.Length - bombPosition - 1;
                            }
                            input = input.Remove(startPosition, strength);
                            break;
                        }
                        else
                        {
                            int nextBombPositionInSubstring = stringToBeDeleted.IndexOf('>');
                            storedStrength = strength - nextBombPositionInSubstring;
                            strength = nextBombPositionInSubstring;
                            if (bombPosition + strength >= input.Length)
                            {
                                strength = input.Length - bombPosition - 1;
                                
                            }
                            input = input.Remove(startPosition, strength);
                        }
                    }
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                    {
                        areThereBombs = true;
                        break;
                    }
                    else
                    {
                        areThereBombs = false;
                    }
                }

            }
            Console.WriteLine(input);
        }
    }
}
