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
        
        public Werk()
        {
        }
        public Werk(Produkt Produkt)
        {
            this.Produkt = Produkt;
        }
        public float berechneUmsatz()
        {
            return (this.Produkt.getAnzahl() * this.Produkt.getPreis());
        }
        public void newProduct(string name, float preis, int anzahl)
        {
            this.Produkt = new Produkt(name, preis, anzahl);
        }
    }

    class Produkt
    {
        private string name;
        private float preis;
        private int anzahl;

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
            Werk w1 = new Werk();
            Werk w2 = new Werk();
            w1.newProduct("4TiB Festplatte", 195.50f, 7000);
            w2.newProduct("250 GiB SSD", 149.90f, 6000);

            f1.addWerk(w1);
            f1.addWerk(w2);

            Console.WriteLine(f1.berechneGesamtUmsatz());
            Console.ReadLine();
        }
    }
}
