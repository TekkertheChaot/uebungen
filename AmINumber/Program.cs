using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmINumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char zeichen;
            int i = 0;

            do
            {
                if (i != 0)
                {
                    Console.WriteLine("I AM NO NUMBER");
                }
                i++;
                zeichen = Convert.ToChar(Console.ReadKey().KeyChar);
                Console.Clear();
            } while (!char.IsNumber(zeichen));

            Console.WriteLine("I AM NUMBER!");
            Console.ReadKey();
        }
    }
}
