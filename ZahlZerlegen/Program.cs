using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahlZerlegen
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 PIN;
            Int16 PINx2;
            Int16 qPIN;
            Console.WriteLine("Gebe eine PIN ein!");
            PIN = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Deine PIN lautet: {0}", PIN);
            PINx2 = Convert.ToInt16(PIN * 2);
            Console.WriteLine("Dein PIN mal 2 ist {0}", PINx2);
            // -- Projekt Abgebrochen --
        }
    }
}
