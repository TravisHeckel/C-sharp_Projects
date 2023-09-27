using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee() { ID = 1, FirstName = "Sample", LastName = "Student" };// creates an instance of employee.cs and assigns two parameters some values.

            Employee newEmployee2 = new Employee() { ID = 2, FirstName = "main", LastName = "Teacher" };// creates an instance of employee.cs and assigns two parameters some values.

            bool check = newEmployee == newEmployee2; //uses the operator to compare two ID
            bool check2 = newEmployee != newEmployee2; //uses the operator to compare two ID

            Console.ReadLine();
        }
    }
}
