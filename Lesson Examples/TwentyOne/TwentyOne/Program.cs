using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

       
    }

}

//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Jesse";
//game = game + player;
//game = game - player;

//Card card1 = new Card();
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;

//Console.WriteLine(card1.Face);



//int count = deck.Cards.Count(x => x.Face == Face.Ace); //1 example
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //2example
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23, }; //example 3 

//int sum = numberList.Sum(x => x + 5); //example 3
// int sum = numberList.Min(); //example 3 
// int sum = numberList.Where(x => x > 20).Sum(); //example 3 