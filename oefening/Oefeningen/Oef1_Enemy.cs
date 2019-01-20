﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Werk de functie ToString() verder uit om ook het FighterType van de player aan de tekst toe te voegen.
 *    (Je kan de mogelijke types bekijken in het bestand Enums.cs)
 * 2. In de TestPlayer() functie voeg je nog drie players toe, die je dan ook op het scherm toont:
 *      - een Chtulhu Mage
 *      - een Gnome Priest
 *      - een Troll Warrior
 */

namespace Game
{
	public class Enemy
	{
        public FighterType Type { get; }
        public Race Race { get; }

        public Enemy(FighterType Type, Race Race)
        {
            this.Type = Type;
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
            if (Type == FighterType.Hunter) result += "hunter.";
            else if (Type == FighterType.Mage) result += "mage.";
            else if (Type == FighterType.Priest) result += "priest.";
            else if (Type == FighterType.Warrior) result += "warrior.";

            return result;
        }

    }

    public partial class Test
    {
        public static void TestEnemy()
        {
            var enemy1 = new Enemy(FighterType.Hunter, Race.Elf);
            Console.WriteLine(enemy1);

            var enemy2 = new Enemy(FighterType.Mage, Race.Cthulhu);
            Console.WriteLine(enemy2);

            // Je kan een nieuw object ook rechtstreeks naar de console sturen,
            // maar dan kan je er achteraf natuurlijk niets meer meer doen.
            Console.WriteLine(new Enemy(FighterType.Priest, Race.Gnome));
            Console.WriteLine(new Enemy(FighterType.Warrior, Race.Troll));
        }
    }
}
