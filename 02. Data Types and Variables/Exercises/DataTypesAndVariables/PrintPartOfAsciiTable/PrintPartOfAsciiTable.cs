﻿using System;

namespace PrintPartOfAsciiTable
{
	class PrintPartOfAsciiTable
	{
		static void Main()
		{
			int start = int.Parse(Console.ReadLine());
			int end = int.Parse(Console.ReadLine());

			for (int i = start; i <= end; i++)
			{
				Console.Write(Convert.ToChar(i) + " ");
			}
		}
	}
}
