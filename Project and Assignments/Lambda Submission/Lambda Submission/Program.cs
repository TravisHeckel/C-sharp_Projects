using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Employee> EmployeeList = new List<Employee>() { //Creates a list of all employees
                new Employee() {ID = 0, FirstName = "Travis", LastName = "Heckel" },
                new Employee() {ID = 1, FirstName = "Joe", LastName = "Christian" },
                new Employee() {ID = 2, FirstName = "Steve", LastName = "Wright" },
                new Employee() {ID = 3, FirstName = "Alexander", LastName = "Johnson" },
                new Employee() {ID = 4, FirstName = "Samantha", LastName = "Angells" },
                new Employee() {ID = 5, FirstName = "Britney", LastName = "Henderson" },
                new Employee() {ID = 6, FirstName = "Bailey", LastName = "Sabey" },
                new Employee() {ID = 7, FirstName = "Roy", LastName = "Gage" },
                new Employee() {ID = 8, FirstName = "Spencer", LastName = "Willets" },
                new Employee() {ID = 9, FirstName = "Joe", LastName = "Humphery" }

            };

            List<Employee> SameEmployeeNames = new List<Employee>();

            foreach (Employee x in EmployeeList) //checks for joe's
            {
                if (x.FirstName == "Joe")
                {
                    SameEmployeeNames.Add(x);
                }
            }

            for (int i = 0; i < SameEmployeeNames.Count; i++) //prints out each joe
            {
                Console.WriteLine(SameEmployeeNames[i].FirstName + " " + SameEmployeeNames[i].LastName);

            }
            

            List<Employee> SameEmployeeNames2 = EmployeeList.Where(x => x.FirstName == "Joe").ToList(); //creates new list and checks for joe's


            Console.WriteLine(SameEmployeeNames2[0].ID + " " + SameEmployeeNames2[0].FirstName + " " + SameEmployeeNames2[0].LastName); //prints out an example of joe to confirm

            List<Employee> SameEmployeeID = EmployeeList.Where(x => x.ID > 5).ToList(); //creates new list and checks for id > 5

            for (int i = 0; i < SameEmployeeID.Count; i++) //prints each item out to console
            {
                Console.WriteLine(SameEmployeeID[i].ID + " " + SameEmployeeID[i].FirstName + " " + SameEmployeeID[i].LastName);

            }

            Console.ReadLine();
        }
    }
}
