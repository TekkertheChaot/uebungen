using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeldKonstrukor
{
    class Konto                         
    {
        private static uint ktoGlobalNr = 400000;
        private double ktoStand;
        private uint ktoNr;

        public Konto()                  
        {
            ktoNr = ktoGlobalNr++;
            ktoStand = 0;
        }
        public Konto(double betrag)     
        {
            ktoStand = betrag;      
        }
        public double getKtoStand()
        {
            return ktoStand;
        }
        public uint getKtoNr()
        {
            return ktoNr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Konto konto1 = new Konto();
            Konto konto2 = new Konto();
            Konto konto3 = new Konto();
            Console.WriteLine("Das folgende Konto mit der Konto-Nummer: {0} wurde angelegt", konto1.getKtoNr());
            Console.WriteLine("Das folgende Konto mit der Konto-Nummer: {0} wurde angelegt", konto2.getKtoNr());
            Console.WriteLine("Das folgende Konto mit der Konto-Nummer: {0} wurde angelegt", konto3.getKtoNr());
            Console.ReadLine();
            
                
        }
    }
}
