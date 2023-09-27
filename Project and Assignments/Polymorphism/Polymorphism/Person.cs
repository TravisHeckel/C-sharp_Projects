using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Person
    {
        public string FirstName { get; set; } //allows us to set the variable
        public string LastName { get; set; } //allows us to set the variable

        public abstract void SayName(); //auto prints a statment when called
        public string choice {get; set; }
    }
}
