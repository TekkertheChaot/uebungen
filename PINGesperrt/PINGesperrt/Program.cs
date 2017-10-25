using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PINGesperrt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blackpin = new string[] { "1234", "0000", "1111" };    //Erstelle Blacklist
            string pin;           // <-- Der da übernimmt unsere PIN abfrage.
            bool pass;

            do
            {
                Console.Clear();
                pass = true;
                Console.WriteLine("Bitte gebe eine PIN ein!");
                pin = Console.ReadLine();
                foreach (string p in blackpin)      // Laufe die Blacklist durch.
                {
                    if (pin == p)                   // Ist die Pin in der Blacklist?
                    {
                        Console.WriteLine("PIN nicht erlaubt!");
                        pass = false;               // Setze Flag, damit die Schleife rotiert.
                        Thread.Sleep(1220);         // Gib dem Benutzer genug Zeit, die Fehlermeldung zu sehen.
                        break;
                    }

                }
            } while (pass == false);

            Console.Clear();
            Console.WriteLine("PIN Akzeptiert.\nProgramm wird beendet...");
            Console.ReadLine();
            
        }
    }
}
