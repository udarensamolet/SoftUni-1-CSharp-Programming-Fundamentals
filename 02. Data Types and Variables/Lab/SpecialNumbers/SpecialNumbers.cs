using System;

namespace SpecialNumbers
{
	class SpecialNumbers
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			double lastDigit = 0;
			int sum = 0;
			int number = 0;

			for (int i = 1; i <= n; i++)
			{
				number = i;
				while (number > 0)
				{
					lastDigit = number % 10;
					number /= 10;
					sum += (int)lastDigit;
				}

				if (sum == 5 || sum == 7 || sum == 11)
				{
					Console.WriteLine($"{i} -> True");
				}
				else
				{
					Console.WriteLine($"{i} -> False");
				}
				sum = 0;
			}
		}
	}
}
