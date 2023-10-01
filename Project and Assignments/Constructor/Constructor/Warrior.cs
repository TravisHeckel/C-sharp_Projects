using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Warrior
    {
            public string race;
            public string weapon;
            public  Warrior() : this("human") // this sets the race to human if no race is given
            {

            }
            public Warrior(string race) : this(race, "fist") //this will set the weapon to fist if no weapon is given
            {

            }
            public Warrior(string race, string weapon) //this will set both the options to whatever the user chose
            {
                this.race = race; // the reference 'this.' means that the default for race will be saved to race IF nothing was in there before
                this.weapon = weapon; // the reference 'this.' means that the default for race will be saved to weapon IF nothing was in there before 
        }

    }
}
