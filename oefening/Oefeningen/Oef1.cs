using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Werk de functie ToString() verder uit om ook de Class van de player aan de tekst toe te voegen.
 * 2. In de TestPlayer() functie voeg je nog drie players toe, die je dan ook op het scherm toont:
 *      - een Chtulhu Mage
 *      - een Gnome Priest
 *      - een Troll Warrior
 *      
 * 3. Maak in het bestand Enums.cs een nieuwe enum met de naam Weapon
 */

namespace Game
{
	public class Player
	{
        public PlayerClass PlayerClass { get; set; }
        public Race Race { get; set; }

        public Player(PlayerClass PlayerClass, Race Race)
        {
            this.PlayerClass = PlayerClass;
            this.Race = Race;
        }

        /* Nieuw: override
         * 
         * Elk object heeft een functie 'ToString'. Console.Write() zal die functie bijvoorbeeld gebruiken
         * om een object op het scherm te tonen. 
         * In de vorige oefenreeks hebben we een functie  'AsText()' gebruikt om een string te genereren. Maar die moeten we dan
         * wel zelf aanroepen. Nu overschrijven we de functie ToString(), en dat heeft als voordeel dat dit de default functie 
         * is om een object als tekst weer te geven. Dit maakt het eenvoudiger om het object te printen in de volgende oefening.
         */
        public override string ToString()
        {
            string result = "This ";
            if (Race == Race.Troll) result += "troll";
            else if (Race == Race.Gnome) result += "gnome";
            else if (Race == Race.Elf) result += "elf";
            else if (Race == Race.Cthulhu) result += "cthulu";

            result += " is a ";

            // vul aan met de player class

            return result;
        }

    }

    public partial class Test
    {
        public static void TestPlayer()
        {
            var player1 = new Player(PlayerClass.Hunter, Race.Elf);
            Console.WriteLine(player1);
        }
    }
}
