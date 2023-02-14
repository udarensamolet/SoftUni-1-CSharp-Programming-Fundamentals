using System;

namespace MultiplicationTable2._0
{
	class MultiplicationTable2
	{
		static void Main()
		{
			int multiplicand = int.Parse(Console.ReadLine());
			int multiplier = int.Parse(Console.ReadLine());

			if (multiplier > 10)
			{
				Console.WriteLine($"{multiplicand} X {multiplier} = {multiplier * multiplicand}");
			}
			else
			{
				for (int i = multiplier; i <= 10; i++)
				{
					Console.WriteLine($"{multiplicand} X {i} = {multiplicand * i}");
				}
			}
		}
	}
}
