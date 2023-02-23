using System;

namespace StrongNumber
{
	class StrongNumber
	{
		static void Main()
		{
			int input = int.Parse(Console.ReadLine());
			int number = input;
			int sum = 0;
			int lastDigit = 0;
			int factorial = 1;


			while (input > 0)
			{
				factorial = 1;
				lastDigit = input % 10;
				input = input / 10;

				while (lastDigit > 1)
				{
					factorial *= lastDigit;
					lastDigit--;
				}
				sum += factorial;
			}

			if (number == sum)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}
