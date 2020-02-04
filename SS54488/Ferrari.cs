using System;
using Dziedziczenie;

namespace SS54488
{
	class Ferrari : IPojazd
	{
		public Silnik Silnik { get; set; }

		public Ferrari(Silnik silnik)
		{
			Silnik = silnik;
		}

		public void Jedz()
		{
			Jedz(10);
		}

		public void Jedz(int dystans)
		{
			ConsoleColor currentColor = Console.ForegroundColor;

			Console.WriteLine("Jedziemy! Zapnij pasy!");

			if (dystans < 6)
			{
				Console.ForegroundColor = ConsoleColor.Red;
			}

			else if (dystans > 12)
			{
				Console.ForegroundColor = ConsoleColor.Green;
			}

			else
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
			}

			for (int i = 0; i < dystans; i++)
			{
				Silnik.Dzialaj();
			};

			Console.ForegroundColor = currentColor;

			Console.WriteLine("\nKoniec jazdy!\n");
		}
	}
}