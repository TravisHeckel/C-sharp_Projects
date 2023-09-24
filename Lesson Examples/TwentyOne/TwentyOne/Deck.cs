using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "clubs", "hearts", "diamonds", "Spades" };
            List<string> Faces = new List<string>() { "two", "three", "four", "five", "six", "seven", 
                                                    "eight", "nine", "ten", "jack", "queen", "king", "ace" };

            foreach (string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards {get; set; }
    }
}
