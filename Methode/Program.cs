using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode
{
    class Reifen
    {
        static public int Methode(string setManu, string setModel)
        {
            if (setManu == "Ford" && setModel == "Focus")
            {
                return 4;
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reifen.Methode("Ford","Focus"));
            Console.ReadLine();
        }
    }
}
