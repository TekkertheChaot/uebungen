using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class demo
    {
        private static int integer;
        public static int Integer
        {
            get { return integer; }
            set {
                    if (value > 10)
                    {
                        integer = 10;
                    }
                    else if (value < 0)
                    {
                        integer = 0;
                    }
                    else integer = value;
                }
        }
    }
}
