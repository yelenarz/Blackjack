using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Dealer
    { 
        public List<Card> Cards { get; private set; }

        public Dealer()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int GetSumValue()
        {
            int sum = 0;
            Cards.ForEach(x => sum += x.Rank.Value);
            return sum;
        }
    }
}
