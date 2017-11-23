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
            long getFibn(int place)
            {
                long m1 = 0,
                       m2 = 1;
    
                for (int i = 0; i < place; i++)
                {
                    long tmp = m1;
                    m1 = m2;
                    m2 = (tmp + m1);
                }
                return m1;
            }
            for (int i = 0; i < 1490; i++)
            {
                Console.WriteLine(getFibn(i));
            }
            Console.ReadLine();
        }
    }
}
