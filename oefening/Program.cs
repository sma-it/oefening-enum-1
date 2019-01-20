using System;

namespace First
{
	class Program
	{


		static void Main(string[] args)
		{
			var menu = new Utils.Menu();
			// voeg oefeningen to door een callback naar een functie
			menu.AddOption('1', "Voer Oef1 uit", () => { Game.Test.TestEnemy(); });
            menu.AddOption('2', "Voer Oef2 uit", () => { Game.Test.TestRoom(); });
            menu.AddOption('3', "Voer Oef3 uit", () => { Game.Test.TestColors(); });
			menu.Start();
		}

		
	}
}
