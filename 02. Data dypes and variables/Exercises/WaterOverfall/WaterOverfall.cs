using System;

namespace WaterOverfall
{
	class WaterOverfall
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			int capacity = 255;
			int pouredLiters = 0;
			int input = 0;

			for (int i = 0; i < n; i++)
			{
				input = int.Parse(Console.ReadLine());
				if (capacity - input >= 0)
				{
					capacity -= input;
					pouredLiters += input;
				}
				else
				{
					Console.WriteLine("Insufficient capacity!");
				}
			}
			Console.WriteLine(pouredLiters);
		}
	}
}
