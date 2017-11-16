using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NachUML
{
    class Firma
    {
        List<Werk> Werke = new List<Werk>();

        public void addWerk(Werk Werk)
        {
            this.Werke.Add(Werk);
        }
        public float berechneGesamtUmsatz()
        {
            float GU = 0;
            foreach (Werk w in this.Werke)
            {
                GU += w.berechneUmsatz();
            }
            return GU;
        }
    }

    class Werk
    {
        private Produkt Produkt;

        public Werk(Produkt Produkt)
        {
            this.Produkt = Produkt;
        }
        public float berechneUmsatz()
        {
            return (this.Produkt.getAnzahl() * this.Produkt.getPreis());
        }
    }

    class Produkt
    {
        private string name;
        private float preis;
        private int anzahl;
        private string p1;
        private double p2;
        private int p3;

        public Produkt(string name, float preis, int anzahl)
        {
            this.name = name;
            this.preis = preis;
            this.anzahl = anzahl;
        }

        public string getName()
        {
            return name;
        }
        public float getPreis()
        {
            return preis;
        }
        public int getAnzahl()
        {
            return anzahl;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Firma f1 = new Firma();
            Produkt p1 = new Produkt("4TiB Festplatte", 105.50f, 7000);
            Produkt p2 = new Produkt("250 GiB SSD", 149.90f, 6000);
            Werk w1 = new Werk(p1);
            Werk w2 = new Werk(p2);

            f1.addWerk(w1);
            f1.addWerk(w2);

            Console.WriteLine(f1.berechneGesamtUmsatz());
            Console.ReadLine();
        }
    }
}
