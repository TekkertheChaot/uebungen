using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    class Kreis
    {
        private int radius;
        private int x;
        private int y;

        public Kreis() {}
        public Kreis(int Radius)
        {
            Radius = radius; 
        }
        public Kreis(int Radius, int sx, int sy)
        {
            radius = Radius;
            x = sx;
            y = sy;
        }
        public int getRad()
        {
            return radius;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kreis KreisRad = new Kreis(10);
            Kreis KreisCoordinate = new Kreis(15,1,2);
            Console.WriteLine("Radius: {0}; X: {1}; Y: {2}", KreisRad.getRad(), KreisRad.getX(), KreisRad.getY());
            Console.WriteLine("Radius: {0}; X: {1}; Y: {2}", KreisCoordinate.getRad(), KreisCoordinate.getX(), KreisCoordinate.getY());
            Console.ReadLine();
        }
    }
}
