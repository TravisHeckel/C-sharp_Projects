using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator== (Employee one, Employee two) //uses operator to compare two id's
        {
            if (one.ID == two.ID)
            {
                Console.WriteLine("they are the same");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee one, Employee two) //uses operator to compare two id's
        {
            if (one.ID != two.ID)
            {
                Console.WriteLine("they are NOT the same");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
