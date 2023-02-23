using System;

namespace GamingStore
{
	class GamingStore
	{
		static void Main()
		{
			double currentBalance = double.Parse(Console.ReadLine());
			double price = 0;
			double startBalance = currentBalance;
			string nameOfGame = null;
			bool outOfMoney = false;
			
			string input = Console.ReadLine();

			while (input != "Game Time")
			{
				switch (input)
				{
					case "OutFall 4":
						price = 39.99;
						nameOfGame = "OutFall 4";
						break;
					case "CS: OG":
						price = 15.99;
						nameOfGame = "CS: OG";
						break;
					case "Zplinter Zell":
						price = 19.99;
						nameOfGame = "Zplinter Zell";
						break;
					case "Honored 2":
						price = 59.99;
						nameOfGame = "Honored 2";
						break;
					case "RoverWatch":
						price = 29.99;
						nameOfGame = "RoverWatch";
						break;
					case "RoverWatch Origins Edition":
						price = 39.99;
						nameOfGame = "RoverWatch Origins Edition";
						break;
					default:
						Console.WriteLine("Not Found");
						nameOfGame = null;
						break;
				}

				if (nameOfGame != null)
				{
					if (currentBalance >= price)
					{
						currentBalance -= price;
						Console.WriteLine($"Bought {nameOfGame}");
						if (currentBalance == 0)
						{
							Console.WriteLine("Out of money!");
							outOfMoney = true;
							break;
						}
					}
					else if (currentBalance > 0 && currentBalance < price)
					{
						Console.WriteLine("Too Expensive");
					}
					else
					{
						Console.WriteLine("Out of money!");
						outOfMoney = true;
						break;
					}
				}

				input = Console.ReadLine();
			}

			if (outOfMoney == false)
			{
				Console.WriteLine($"Total spent: ${(startBalance - currentBalance):f2}. Remaining: ${currentBalance:f2}");
			}
		}
	}
}
