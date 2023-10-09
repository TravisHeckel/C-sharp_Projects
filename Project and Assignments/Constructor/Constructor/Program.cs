using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior newWarrior = new Warrior();//set up new warrior instance
            Warrior newWarrior2 = new Warrior("fox", "hammer");//set up new warrior instance
            Warrior newWarrior3 = new Warrior("borg"); //set up new warrior instance

            Console.WriteLine(newWarrior.race + " " + newWarrior.weapon); //prints out instances items
            Console.WriteLine(newWarrior2.race + " " + newWarrior2.weapon); //prints out instances items
            Console.WriteLine(newWarrior3.race + " " + newWarrior3.weapon); //prints out instances items

            const string animal = "dog";
            var animal2 = "cat";

            Console.WriteLine(animal + " is better than " + animal2); //prints out instances items

            Console.ReadLine();
        }
    }
}
