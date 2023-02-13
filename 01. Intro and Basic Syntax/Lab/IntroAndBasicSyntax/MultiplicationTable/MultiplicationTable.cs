using System;

namespace MultiplicationTable
{
	class MultiplicationTable
	{
		static void Main()
		{
			int input = int.Parse(Console.ReadLine());

			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine($"{input} X {i} = {input * i}");
			}
		}
	}
}
