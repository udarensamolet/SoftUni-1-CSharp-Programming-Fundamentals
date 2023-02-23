using System;

namespace SortNumber
{
	class SortNumber
	{
		static void Main()
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			int first = 0;
			int second = 0;
			int third = 0;

			if (a > b)
			{
				if (a > c)
				{
					first = a;
					if (b > c)
					{
						second = b;
						third = c;
					}
					else
					{
						second = c;
						third = b;
					}
				}
				else
				{
					first = c;
					second = a;
					third = b;
				}
			}
			else
			{
				if (b > c)
				{
					first = b;
					if (a > c)
					{
						second = a;
						third = c;
					}
					else
					{
						second = c;
						third = a;
					}
				}
				else
				{
					first = c;
					second = b;
					third = a;
				}
			}
			Console.WriteLine(first);
			Console.WriteLine(second);
			Console.WriteLine(third);
		}
	}
}
