using System;

namespace Messages
{
	class Messages
	{
		static void Main()
		{
			int lengthSMS = int.Parse(Console.ReadLine());

			string inputDigits = null;
			int count = 0;
			int input = 0;
			int digit = 0;
			int offset = 0;
			int letterIndex = 0;

			string output = null;

			for (int i = 0; i < lengthSMS; i++)
			{
				inputDigits = Console.ReadLine();
				count = inputDigits.Length;
				input = Convert.ToInt32(inputDigits);
				digit = input % 10;

				if (digit == 8 || digit == 9)
				{
					offset = ((digit - 2) * 3) + 1;
				}
				else
				{
					offset = (digit - 2) * 3;
				}

				letterIndex = offset + count - 1;
				if (letterIndex == -6)
				{
					letterIndex = -65;
				}
				output += Convert.ToChar(letterIndex + 97);
			}
			
			Console.WriteLine(output);
		}
	}
}
