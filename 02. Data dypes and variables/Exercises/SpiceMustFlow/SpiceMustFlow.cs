using System;

namespace SpiceMustFlow
{
	class SpiceMustFlow
	{
		static void Main()
		{
			int yieldPerDay = int.Parse(Console.ReadLine());
			int countDays = 0;
			int yieldExtracted = 0;

			if (yieldPerDay >= 100)
			{
				while (yieldPerDay >= 100)
				{
					countDays++;
					if (countDays == 1)
					{
						yieldExtracted = yieldPerDay - 26;
					}
					else
					{
						yieldExtracted += (yieldPerDay - 26);
					}
					yieldPerDay -= 10;

				}
				yieldExtracted -= 26;
				Console.WriteLine(countDays);
				Console.WriteLine(yieldExtracted);
			}
			else
			{
				Console.WriteLine(0);
				Console.WriteLine(0);
			}
		}
	}
}
