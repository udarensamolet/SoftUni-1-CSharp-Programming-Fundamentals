using System;

namespace PoundsToDollars
{
	class PoundsToDollars
	{
		static void Main()
		{
			decimal num = decimal.Parse(Console.ReadLine());
			decimal result = num * 1.31M;
			Console.WriteLine($"{result:f3}");
		}
	}
}
