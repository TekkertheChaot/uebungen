using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KleinerGeldautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            int guthaben = 20000;
            int betrag = 0;
            while (guthaben >=1000) 
            {
                byte act;

                Console.WriteLine("Was möchten sie tun?\n\n1) Geld abheben\n0) Beenden");
                act = Convert.ToByte(Console.ReadLine());
                Console.Clear();
                switch (act)
                {
                    case 1:
                        Console.Write("Bitte geben sie den Betrag an, den sie abheben möchten!\nBetrag in EUR: ");
                        betrag = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                        guthaben = guthaben - betrag;
                        Console.WriteLine("Bitte sehr!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Dieser Automat steht momentan nicht zur Verfügung. (Nicht genügend Geld)");
            Console.ReadLine();
        }
    }
}
