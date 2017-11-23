using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double store0 = 0;
            double store1 = 0;
            double fibn = 0;

            int n = 1;
            for (int i = 0; i <= n; i++)
            {
                if(n==0)
                {
                    store1 = 1;
                }
                fibn = (store0 + store1);
                store0 = store1;
                store1 = fibn;

            }

            Console.WriteLine(fibn);
            Console.ReadLine();
        }
    }
}
