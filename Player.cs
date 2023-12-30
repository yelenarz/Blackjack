using Blackjack.Rank;
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

        internal void RemoveCard(Card last)
        {
            Cards.Remove(last);
        }
    }
}