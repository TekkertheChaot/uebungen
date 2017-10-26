using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjekteGeldautomat
{
    class Konto
    {
        private double ktoStand;
        public double getKtoStand()
        {
            return ktoStand;
        }
        public double buchung(double betrag)
        {
            if (ktoStand + betrag >= 0)
            {
                ktoStand += betrag;
                return ktoStand;
            }
            else
                return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Konto konto1 = new Konto();     // Geht das nicht auch in einem Array?
            Konto konto2 = new Konto();     // Geht das nicht auch in einem Array?
            Konto konto3 = new Konto();     // Geht das nicht auch in einem Array?
            konto1.buchung(100);
            konto2.buchung(2000);
            konto3.buchung(50000);
            Console.WriteLine("Kontostand von Konto 1: {0}\nKontostand von Konto 2: {1}\nKontostand von Konto 3: {2}", konto1.getKtoStand(),konto2.getKtoStand(),konto3.getKtoStand());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
