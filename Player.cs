using Blackjack.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    /* 
    * This class is for player, which is keeping track of the cards he holds during the game,
    * its count and the money he current owns.
    */
    public class Player
    {
        public int Money { get; set; }
        public List <Card> Cards { get; private set; }

        public Player(int money)
        {
            Money = money;
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public bool IsBlackJack()
        {
            return Cards.Count == 2 && GetSumValue() == 21;
        }

        /*
        *  The following function calculates the total count of the player's cards 
        *  in the game, and if the total, with an ace counted as 11, exceeds 21, 
        *  adjust the ace count to 1.
        */
        public int GetSumValue()
        {
            int sum = 0;
            Cards.ForEach(x =>
            {
                HeroRank heroRank = x.Rank as HeroRank;
                if (heroRank != null)
                {
                    heroRank.MaxMode = true;
                }
            });
            Cards.ForEach(x => sum += x.Rank.Value);
            if (sum <= 21)
            {
                return sum;
            }

            sum = 0;
            Cards.ForEach(x =>
            {
                HeroRank heroRank = x.Rank as HeroRank;
                if (heroRank != null)
                {
                    heroRank.MaxMode = false;
                }
            });
            Cards.ForEach(x => sum += x.Rank.Value);
            return sum;
        }

        /*
         * This is for the split, to remove the second card from first hand and add it
         * to the second hand
         */
        internal void RemoveCard(Card last)
        {
            Cards.Remove(last);
        }
    }
}