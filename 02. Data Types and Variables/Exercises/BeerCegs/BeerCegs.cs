using System;

namespace BeerCegs
{
	class BeerCegs
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			string model;
			double radius;
			int height;

			double volume = 0;
			double largestVolume = Double.MinValue;

			string biggest = null;

			for (int i = 0; i < n; i++)
			{
				model = Console.ReadLine();
				radius = double.Parse(Console.ReadLine());
				height = int.Parse(Console.ReadLine());

				volume = Math.PI * Math.Pow(radius, 2) * height;

				if (volume > largestVolume)
				{
					biggest = model;
					largestVolume = volume;
				}
			}
			Console.WriteLine(biggest);
		}
	}
}
