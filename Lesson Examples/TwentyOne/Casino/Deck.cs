using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); //this creates a new EMPTY list called CARDS
            for (int i = 0; i < 13; i++) //circulates thru the 13 different FACES
            {
                for (int j = 0; j < 4; j++) //circulates thru the four different SUITS
                {
                    Card card = new Card(); //creates an instance of Card named card
                    card.Face = (Face)i; //sets the attribute from CARD.FACE the first one in the list of FACES (this stays the same for the 4 different cycles)
                    card.Suit = (Suit)j; // sets the attribute of the CARD.SUIT that is in the list of SUITS (this cycles thru 4 different attributes)
                    Cards.Add(card); //this adds the card to the list
                }
            }
        }
        public List<Card> Cards {get; set; } //This creates a CARDS list method that can be accessed from the deck class.

        public void Shuffle( int times = 1) //this shuffles the cards 1 time
        {
            for (int i = 0; i < times; i++) //cycles thru once
            {
                List<Card> TempList = new List<Card>(); //this creates a temporary list to store values on
                Random random = new Random(); //this sets the random variable

                while (Cards.Count > 0) //this cycles thru all the cards until there are none left(I mean't the different positions inside of the Cards List)
                {
                    int randomIndex = random.Next(0, Cards.Count); //this randomly picks a number from 0 - 52(Cards.Count max).
                    TempList.Add(Cards[randomIndex]);//this sets the index = to the random value given and adds those values to the temporary list
                    Cards.RemoveAt(randomIndex); //this specifically choses the index spot we just pulled from and removes all the values/spot. this also resets the Cards.Count -1
                }
                Cards = TempList; //this re-sets the cards list to what the templist held
            }
        }

    }
}
