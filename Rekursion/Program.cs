using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            String RekD(int x)
            {
                return RekA(x);
            }

            String RekA(int n)
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

            String RekB()
            {
                return "Wrecked";
            }
            
            Console.WriteLine(RekD(1));
            Console.ReadLine();
        }
    }
}
