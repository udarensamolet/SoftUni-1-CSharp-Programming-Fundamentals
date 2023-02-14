using System;

namespace BackIn30Minutes
{
	class BackIn30Minutes
	{
		static void Main()
		{
			int hoursInput = int.Parse(Console.ReadLine());
			int minsInput = int.Parse(Console.ReadLine());

			if (minsInput < 30)
			{
				Console.WriteLine($"{hoursInput}:{minsInput + 30}");
			}
			else
			{
				if (hoursInput < 23)
				{
					if (minsInput + 30 - 60 < 10)
					{
						Console.WriteLine($"{hoursInput + 1}:0{minsInput + 30 - 60}");
					}
					else
					{
						Console.WriteLine($"{hoursInput + 1}:{minsInput + 30 - 60}");
					}
				}
				else
				{

					if (minsInput + 30 - 60 < 10)
					{
						Console.WriteLine($"{hoursInput + 1 - 24}:0{minsInput + 30 - 60}");
					}
					else
					{
						Console.WriteLine($"{hoursInput + 1 - 24}:{minsInput + 30 - 60}");
					}
				}
			}
		}
	}
}
