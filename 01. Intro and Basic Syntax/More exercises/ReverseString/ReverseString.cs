using System;

namespace ReverseString
{
	class ReverseString
	{
		static void Main()
		{
			string input = Console.ReadLine();
			string output = null;

			char[] arrayInput = input.ToCharArray();
			Array.Reverse(arrayInput);
			output = new string(arrayInput);

			Console.WriteLine(output);
		}
	}
}
