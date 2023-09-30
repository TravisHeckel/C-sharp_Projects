using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; } //this gives us a method we can get/set
        public Deck Deck { get; set; }  //this gives us a method we can get/set that using the data type Deck (see deck for the inherited class information) to create the standard DECK we will be pulling from
        public int Balance { get; set; }  //this gives us a method we can get/set
        public void Deal(List<Card> Hand) //this is a void statment that runs standard, it access the HAND LIST
        {
            Hand.Add(Deck.Cards.First());//this adds the first card from the CARDS list to the hand 
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //this prints out what card is chosen
            using (StreamWriter file = new StreamWriter(@"C:\Users\theck\Documents\Repositories\GitHub\Basic_C-Sharp_Projects\Lesson Examples\Logs\log.txt", true))
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); //this removes that first card from the CARDS list

        }

    }
}
