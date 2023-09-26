using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person //inherits all the Person class attributes
    {
        public int ID { get; set; } //sets the id for the employee

        public override void SayName() //auto prints a statment when called
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
