using System;

namespace PadawanEquipment
{
	class PadawanEquipment
	{
		static void Main()
		{
			double availableMoney = double.Parse(Console.ReadLine());
			int countPadawans = int.Parse(Console.ReadLine());
			double priceLightsabers = double.Parse(Console.ReadLine());
			double priceRobes = double.Parse(Console.ReadLine());
			double priceBelts = double.Parse(Console.ReadLine());

			int countFreeBelts = countPadawans / 6;

			double priceNeededEquipment = ((countPadawans + Math.Ceiling(0.1 * countPadawans)) * priceLightsabers) + (countPadawans * priceRobes) + ((countPadawans - countFreeBelts) * priceBelts);

			if (priceNeededEquipment <= availableMoney)
			{
				Console.WriteLine($"The money is enough - it would cost {priceNeededEquipment:f2}lv.");
			}
			else
			{
				Console.WriteLine($"John will need {(priceNeededEquipment - availableMoney):f2}lv more.");
			}
		}
	}
}
