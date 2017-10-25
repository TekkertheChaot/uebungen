using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAuslesen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {0,1,2,3,4,5,6,7,8,9,8,7,6,5,4,3,2,1,0};

            foreach (int number in myArray) 
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
