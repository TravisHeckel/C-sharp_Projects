using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Number one = new Number();
            one.amount = 12.75m;
            Console.WriteLine(one.amount);
            Console.ReadLine();
        }
    }

    public struct Number
    {
        public decimal amount { get; set; }
    }
}
