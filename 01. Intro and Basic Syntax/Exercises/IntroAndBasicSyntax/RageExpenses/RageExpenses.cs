using System;

namespace RageExpenses
{
	class RageExpenses
	{
		static void Main()
		{
			int countLostGames = int.Parse(Console.ReadLine());
			double priceHeadset = double.Parse(Console.ReadLine());
			double priceMouse = double.Parse(Console.ReadLine());
			double priceKeyboard = double.Parse(Console.ReadLine());
			double priceDisplay = double.Parse(Console.ReadLine());

			int countTrashedHeadset = countLostGames / 2;
			int countTrashedMouse = countLostGames / 3;
			int countTrashedKeyboard = countLostGames / 6;
			int countTrashedDisplay = countTrashedKeyboard / 2;

			double expenses = countTrashedHeadset * priceHeadset + countTrashedMouse * priceMouse + countTrashedKeyboard * priceKeyboard + countTrashedDisplay * priceDisplay;

			Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
		}
	}
}
