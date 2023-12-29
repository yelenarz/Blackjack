using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player
    {
        public int Money { get; set; }
        public List <Card> Cards { get; private set; }

        public List<Card> SplitCards1 { get; private set; }
        public List<Card> SplitCards2 { get; private set; }

        public Player(int money)
        {
            Money = money;
            Cards = new List<Card>();
            SplitCards1 = new List<Card>();
            SplitCards2 = new List<Card>();
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