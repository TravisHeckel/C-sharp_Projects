using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer //-------------this inherites form dealer
    {
        private List<Card> _hand = new List<Card>(); //this gives the dealer a list<hand> to store cards he is given.

        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //this creates an instance of his hand to  run in each round.
        public bool Stay { get; set; } //this stores a bool of whether the dealer decides to stay his hand each round
        public bool isBusted { get; set; } //this bool determines if the cards are over 21

    }
}
