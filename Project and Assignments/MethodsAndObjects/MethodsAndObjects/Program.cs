﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee() { FirstName = "Sample", LastName = "Student" };// creates an instance of employee.cs and assigns two parameters some values.

            newEmployee.SayName(); //runs the method SayName that is a superclass from Person.cs

            Console.ReadLine();
        }
    }
}
