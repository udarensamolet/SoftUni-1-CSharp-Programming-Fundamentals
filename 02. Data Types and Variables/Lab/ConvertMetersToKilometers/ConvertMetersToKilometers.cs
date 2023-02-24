using System;

namespace ExactSumOfRealNumbers
{
	class ExactSumOfRealNumbers
	{
		static void Main()
		{
			int meters = int.Parse(Console.ReadLine());
			decimal kilometers = meters / 1000M;
			Console.WriteLine($"{kilometers:f2}");
		}
	}
}