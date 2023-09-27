using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable //inherits all the Person class attributes
    {
        public int ID { get; set; } //sets the id for the employee

        public override void SayName() //auto prints a statment when called
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quittable() //interface statment from Iquittable
        {
            Console.WriteLine("is deciding if they want to stay or quit!");
        }
    }
}
