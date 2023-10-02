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
            //Warrior newWarrior = new Warrior(); //set up new warrior instance


            //Console.WriteLine("what race are you?"); //ask for user input
            //Console.WriteLine("ork"); //set options
            //Console.WriteLine("elf"); //set options
            //Console.WriteLine("robot"); //set options
            //Console.WriteLine("human"); //set options
            //string answer = Console.ReadLine(); //save user input

            //newWarrior.race = answer; //save user input to the race variable in the class 


            //Console.WriteLine("what weapon do you have?"); //ask for user input
            //Console.WriteLine("laser"); //set options
            //Console.WriteLine("knife"); //set options
            //Console.WriteLine("club"); //set options
            //Console.WriteLine("fist"); //set options
            //string answer2 = Console.ReadLine(); // save user input

            //newWarrior.weapon = answer2;  //save user input to the weapon variable in the class 

            //Console.WriteLine(newWarrior.race + " " + newWarrior.weapon); //prints out the items chosen to the console.

            Console.ReadLine();
        }
    }
}
