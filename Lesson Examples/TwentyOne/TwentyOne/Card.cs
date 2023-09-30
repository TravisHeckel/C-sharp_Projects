using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card //this is a type of function
    {

        public Suit Suit { get; set; } //this creates a state that we can both get and setup
        public Face Face { get; set; } //this creates a state that we can both get and setup

        public override string ToString() //this to string will alwyas make sure to print the face of suit
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit //this enum sets the datatype limits
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face //this enum sets the datatype limits
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace

    }
}
