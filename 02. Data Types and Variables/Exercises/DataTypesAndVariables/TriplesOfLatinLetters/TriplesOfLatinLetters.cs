using System;

namespace TriplesOfLatinLetters
{
	class TriplesOfLatinLetters
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 97; i < 97 + n; i++)
			{
				for (int j = 97; j < 97 + n; j++)
				{
					for (int k = 97; k < 97 + n; k++)
					{
						Console.Write(Convert.ToChar(i));
						Console.Write(Convert.ToChar(j));
						Console.Write(Convert.ToChar(k));
						Console.WriteLine();
					}
				}
			}
		}
	}
}
