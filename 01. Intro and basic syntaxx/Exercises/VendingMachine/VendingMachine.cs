using System;

namespace VendingMachine
{
	class VendingMachine
	{
		static void Main()
		{
			string inputFirst = Console.ReadLine();
			
			double sum = 0;
			double incomingCoin = 0;

			while (inputFirst != "Start")
			{
					incomingCoin = Convert.ToDouble(inputFirst);
					if (incomingCoin == 0.1 || incomingCoin == 0.2 || incomingCoin == 0.5
						|| incomingCoin == 1 || incomingCoin == 2)
					{
						sum += incomingCoin;
					}
					else
					{
						Console.WriteLine($"Cannot accept {incomingCoin}");
					}
				inputFirst = Console.ReadLine();
			}

			string inputSecond = Console.ReadLine();

			while (inputSecond != "End")
			{
					if (inputSecond == "Nuts")
					{
						if (sum >= 2)
						{
							Console.WriteLine("Purchased nuts");
							sum -= 2;
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
					}
					else if (inputSecond == "Water")
					{
						if (sum >= 0.7)
						{
							Console.WriteLine("Purchased water");
							sum -= 0.7;
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
					}
					else if (inputSecond == "Crisps")
					{
						if (sum >= 1.5)
						{
							Console.WriteLine("Purchased crisps");
							sum -= 1.5;
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
					}
					else if (inputSecond == "Soda")
					{
						if (sum >= 0.8)
						{
							Console.WriteLine("Purchased soda");
							sum -= 0.8;
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
					}
					else if (inputSecond == "Coke")
					{
						if (sum >= 1.0)
						{
							Console.WriteLine("Purchased coke");
							sum -= 1.0;
						}
						else
						{
							Console.WriteLine("Sorry, not enough money");
						}
					}
					else
					{
						Console.WriteLine("Invalid product");
					}
				inputSecond = Console.ReadLine();
			}
			Console.WriteLine($"Change: {sum:f2}");
		}
	}
}
