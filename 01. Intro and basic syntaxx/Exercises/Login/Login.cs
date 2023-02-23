using System;

namespace Login
{
	class Login
	{
		static void Main()
		{
			string user = Console.ReadLine();
			string passInput = Console.ReadLine();
			int counter = 0;

			char[] password = user.ToCharArray();
			Array.Reverse(password);
			string pass = new string(password);

			while (true)
			{
				if (passInput == pass)
				{
					Console.WriteLine($"User {user} logged in.");
					break;
				}
				else
				{
					if (counter == 3)
					{
						Console.WriteLine($"User {user} blocked!");
						break;
					}
					else
					{
						Console.WriteLine("Incorrect password. Try again.");
						passInput = Console.ReadLine();
						counter++;
					}
				}
			}
			
		}
	}
}
