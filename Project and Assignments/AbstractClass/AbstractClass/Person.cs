using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        public string FirstName { get; set; } //allows us to set the variable
        public string LastName { get; set; } //allows us to set the variable

        public virtual void SayName() //auto prints a statment when called
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
