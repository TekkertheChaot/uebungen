using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoundReifen
{
    class Auto
    {
        private Reifen[] arrReifen = new Reifen[4];         //Reifen-Arraay Anlegen
        public int checkReifenDruck(int Reifennummer)       //Reifendruck abfragen, Reifennummer Hinterlegen
        {
            return arrReifen[Reifennummer].getDruck();      //Ruft Methode aus der Klasse 'Reifen' ab
        }

        public bool checkReifen(int Reifennummer)           //Reifen existent?
        {
            if (arrReifen[Reifennummer] != null)            //Ist die Stelle <Reifennummer> im Array initiallisiert worden? (möglich durch das Aufrufen der 'addReifen' Methode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addReifen(int ReifenNummer, int ReifenDruck)    // Füge Reifen hinzu
        {
            arrReifen[ReifenNummer] = new Reifen();
            arrReifen[ReifenNummer].setDruck(ReifenDruck);
        }

        public void removeReifen(int ReifenNummer)          // Nehme Reifen weg.
        {
            arrReifen[ReifenNummer] = null;
        }
    }


    class Reifen
    {
        private int druck;
        public void setDruck(int setdruck)
        {
            druck = setdruck;
        }
        
        public int getDruck()
        {
            return druck;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int anzahlReifen = 0;                   //Speichert später die Anzahl der hinzugefügten Reifen
            Auto MyAuto = new Auto();               //Auto wird erstellt
            MyAuto.addReifen(1, 21);                //Reifen werden angebracht (Es wird im 'arrReifen' die Stelle im Index 1 initiallisiert und der Reifen bekommt Druck (21))
            MyAuto.addReifen(3, 25);

            for (int i = 0; i < 4;i++ )             //Zählt die angebrachten (initialisierten) Reifen
            {
                if (MyAuto.checkReifen(i) == true)
                {
                    anzahlReifen++;
                }
            }
            
            Console.WriteLine("Das Auto hat {0} Reifen.", anzahlReifen);

            for (int i = 0; i < 4; i++)
            {
                if (MyAuto.checkReifen(i) == true)
                {
                    Console.WriteLine("Reifen {0} hat einen Druck von {1} PSI.", i, MyAuto.checkReifenDruck(i));
                }
            }
            Console.ReadLine();
        }
    }
}
