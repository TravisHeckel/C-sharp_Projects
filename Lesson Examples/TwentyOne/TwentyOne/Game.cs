using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); //this creates a private list of players

        public List<Player> Players { get { return _players; } set { _players = value; } } //this list is created for the user ot access/create the Players in the list

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>(); //this creates a private dictionary that is ready to store values

        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } //this dictionary allows the access to the private dictionary  thats ready for storing data

        public string Name { get; set; } //this gives the user access to the name reference inside game class
        public abstract void Play(); //this creates a play method that is abstract(meaning it will be required by any class that inherits it to use it.
        public virtual void ListPlayers() //this creates a listPlayers() that can be used and changed in another class
        {
            foreach (Player player in Players) //reviews thru the players in the list
            {
                Console.WriteLine(player.Name); //prints the name of those in the list.
            }
        }

    }
}

