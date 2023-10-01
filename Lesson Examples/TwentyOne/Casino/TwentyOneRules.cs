using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //this creates a dictionary that contains values that are linked to each specific face card
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand) //this is a private method that accepts a 'hand of cards' and checks it against all possible values
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);//this checks the card and 'counts' how many aces there are andsaves ot to aceCount
            int[] result = new int[aceCount + 1]; //then a new array is created that saves the index size to aceCount +1
            int value = Hand.Sum(x => _cardValues[x.Face]); //this value checks the hand and adds the points together for each card 
            result[0] = value; //this value overshadows the result in the first spot on result and saves all the card points
            if (result.Length == 1) //if there is one spot in there then it just returns the results[0]
            {
                return result; //returns the array
            }
            for (int i = 1; i < result.Length; i++) //if there is more than 1 ace in results then it runs this for loop that will take each point in the RESULT array starting in spot 1 NOT 0
            {
                value += (i * 10); //this take the value saved and adds 11
                result[i] = value; //this saves the value in the specific spot
            }
            return result; //returns the array
        }

        public static bool CheckForBlackJack(List<Card> Hand) //this checks the hand of the player OR dealer and returns a bool
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); //this uses the above private method to analyze what the possible values the hand can have and save to a variable
            int value = possibleValues.Max(); //this will select the max value and set it as the variable value 
            if (value == 21) return true; //this checks for black jack and returns a bool
            else return false; //this returns a bool if not 21

        }

        public static bool IsBusted(List<Card> Hand) //This checks the hand to see if they ar over 21
        {
            int value = GetAllPossibleHandValues(Hand).Min(); //takes the HAND and runs it thru the private class above
            if (value > 21) return true;  //this checks for black jack and returns a bool
            return false; //this returns a bool if not 21
        }

        public static bool ShouldDealerStay (List<Card> Hand) //this reviews if dealer is staying within the rules the casino set
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand); //this takes the hand and runs it thru the private class above
            foreach (int value in possibleHandValues) //goes thru the possible values your result array saved from the hand
            {
                if (value > 6 && value < 22) //if the number is between the two values 
                {
                    return true; //choose to stay
                }
            }
            return false; //return false 
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand) //this compares the hand of each player and dealer to see who wins at the end
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand); //check all results the player hand can have using private class
            int[] dealerResults = GetAllPossibleHandValues(DealerHand); //check all results the dealer hand can have using private class

            int playerScore = playerResults.Where(x => x < 22).Max(); //use the max option from the array
            int dealerScore = dealerResults.Where(x => x < 22).Max(); // use the max option in the array

            if (playerScore > dealerScore) return true; //return true for player win
            else if (playerScore < dealerScore) return false; //return false for player loss
            else return null; // return null for draw



        }
    }
}
