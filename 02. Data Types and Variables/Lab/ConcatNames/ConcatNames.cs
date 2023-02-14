using System;

namespace ConcatNames
{
	class ConcatNames
	{
		static void Main()
		{
			string firstName = Console.ReadLine();
			string secondName = Console.ReadLine();
			string delimeter = Console.ReadLine();

			Console.WriteLine(firstName+delimeter+secondName);
		}
	}
}
