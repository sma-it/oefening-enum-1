using System;

namespace First
{
	class Program
	{


		static void Main(string[] args)
		{
			var menu = new Utils.Menu();
			// voeg oefeningen to door een callback naar een functie
			menu.AddOption('1', "Voer Oef1 uit", () => { Game.Test.TestPlayer(); });


			menu.Start();
		}

		static void DoOef1()
		{
			//if(Oef1.Oefening() == true)
			//{
				Console.WriteLine("This is correct!");
			//}
		}
	}
}
