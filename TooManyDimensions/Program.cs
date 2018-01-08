using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooManyDimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] myArray = new string[,]
            {
                {"1","2"},
                {"3","4"},
                {"5","6"}
            };
            Console.WriteLine(myArray[2,1]);
        }
    }
}
