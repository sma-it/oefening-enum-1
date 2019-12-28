using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Open eerst het bestand Enums.cs en voeg een nieuwe enum toe met 
 *    de naam 'RoomSize', en de waarden Small, Medium en Big.
 *    
 * 2. Geef de Room class hieronder een property 'Size' van het type RoomSize.
 * 
 * 3. Voeg een constructor toe die je verplicht om de grootte van de room
 *    vast te leggen bij het maken van een room. Pas ook de aanroep van de 
 *    constructors in de testfunctie aan.
 *    
 * 4. Override de functie ToString(), zodat je een beschrijving van de
 *    room op het scherm kan tonen. Bijvoorbeeld: "This is a small room."
 */

namespace Game
{
    public class Room
    {

    }

    public partial class Test
    {
        public static void TestRoom()
        {
            var smallRoom = new Room();
            var mediumRoom = new Room();
            var bigRoom = new Room();

            Console.WriteLine(smallRoom);
            Console.WriteLine(mediumRoom);
            Console.WriteLine(bigRoom);

            
        }
    }
}
