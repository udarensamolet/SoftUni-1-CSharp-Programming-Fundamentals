using System;

namespace RefactorSpecialNumbers
{
	class RefactorSpecialNumbers
	{
		static void Main()
		{
			int input = int.Parse(Console.ReadLine());
			int sum = 0;
			int currNumber = 0;
			bool result = false;

			for (int i = 1; i <= input; i++)
			{
				currNumber = i;
				while (currNumber > 0)
				{
					sum += currNumber % 10;
					currNumber = currNumber / 10;
				}

				result = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine("{0} -> {1}", i, result);
				sum = 0;
			}
		}
	}
}
