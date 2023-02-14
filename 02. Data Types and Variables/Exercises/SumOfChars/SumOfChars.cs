using System;

namespace SumOfChars
{
	class SumOfChars
	{
		static void Main()
		{
			int count = int.Parse(Console.ReadLine());
			char input;
			int sum = 0;

			for (int i = 0; i < count; i++)
			{
				input = char.Parse(Console.ReadLine());
				sum += input;
			}
			Console.WriteLine($"The sum equals: {sum}");
		}
	}
}
