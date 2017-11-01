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
            Konto[] kontos = new Konto[4];
            string[] arrString = new String[4];
            // foreach (Konto k in kontos)
            // {
            //     k = new Konto(); 
            // }
            for (int i = 0; i < kontos.Length; i++ )
            {
                kontos[i] = new Konto();
                kontos[i].buchung(100+(i*56.3));
                Console.WriteLine(kontos[i].getKtoStand());
            }
            // kontos[0].buchung(100);
            // Console.WriteLine("Kontostand von Konto 1: {0}", kontos[0].getKtoStand());
            // Console.WriteLine(kontos[0].buchung(121));
            Console.ReadLine();
        }
    }
}
