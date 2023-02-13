using System;

namespace ReversedChars
{
	class ReversedChars
	{
		static void Main()
		{
			char first = char.Parse(Console.ReadLine());
			char second = char.Parse(Console.ReadLine());
			char third = char.Parse(Console.ReadLine());

			Console.WriteLine($"{third} {second} {first}");
		}
	}
}
