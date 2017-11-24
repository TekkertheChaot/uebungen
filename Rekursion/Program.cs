using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    class Rekursion
    {
        public String RekD(int x)
        {
            return RekA(x);
        }

        public String RekA(int n)
        {
            if (n <= 0)
            {
                return RekB();
            }
            else
            {
                return "Rickety " + RekA(n - 1);
            }
        }

        public String RekB()
        {
            return "Wrecked";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rekursion TestRek = new Rekursion();
            string test = TestRek.RekD(1);
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
