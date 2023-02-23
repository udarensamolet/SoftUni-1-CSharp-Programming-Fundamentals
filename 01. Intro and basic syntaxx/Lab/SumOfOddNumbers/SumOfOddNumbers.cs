using System;

namespace SumOfOddNumbers
{
	class SumOfOddNumbers
	{
		static void Main()
		{
			int input = int.Parse(Console.ReadLine());
			int sum = 0;
			int number = 1;
			int counter = 0;

			while (counter < input)
			{
				Console.WriteLine(number);
				counter++;
				sum += number;
				number += 2;
			}
			Console.WriteLine($"Sum: {sum}");
		}
	}
}
