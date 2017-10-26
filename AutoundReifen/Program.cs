using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoundReifen
{
    class Auto
    {
        private Reifen[] arrReifen = new Reifen[4];

        public bool checkReifen(int Reifennummer)
        {
            if (arrReifen[Reifennummer] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addReifen(int ReifenNummer, int ReifenDruck)
        {
            arrReifen[ReifenNummer-1] = new Reifen();
            arrReifen[ReifenNummer-1].setDruck(ReifenDruck);
        }
        public void removeReifen(int ReifenNummer)
        {
            arrReifen[ReifenNummer - 1] = null;
        }
    }

    class Reifen
    {
        private int Druck;
        public void setDruck(int druck)
        {
            Druck = druck;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int anzahlReifen = 0;
            Auto MyAuto = new Auto();
            MyAuto.addReifen(1, 21);
            MyAuto.addReifen(3, 25);
            MyAuto.removeReifen(3);

            for (int i = 0; i < 4;i++ )
            {
                if (MyAuto.checkReifen(i) == true)
                {
                    anzahlReifen++;
                }
            }
            Console.WriteLine("Das Auto hat {0} Reifen.", anzahlReifen);
            Console.ReadLine();
        }
    }
}
