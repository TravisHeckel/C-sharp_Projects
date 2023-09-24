using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class op
    {
        public int Number1 { get; set; }
        public int Number2 = 2;
        public string numer;
        public int Multiply()
        {
           int x = Number1 * Number2;
            numer = " times ";
            return x;
        }

        public int Divide()
        {
            int x = Number1 / Number2;
            numer = " divide ";
            return x;
        }

        public int Addition()
        {
            int x = Number1 + Number2;
            numer = " plus ";
            return x;
        }

    }
}
