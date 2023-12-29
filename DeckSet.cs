using Blackjack.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{ 
    public class DeckSet
    {
        public List<Card> Cards { get; private set; }

        public DeckSet(int deskCount)
        {
            Cards = new List<Card>();
            var suits = Enum.GetValues<ESuit>();
            var heros = Enum.GetValues<EHero>();
            for(int i = 0; i < deskCount; i++)
            {
                foreach(ESuit suit in suits)
                {
                    for (int num = 2; num <= 10; num++)
                    {
                        Cards.Add(new Card(suit, new NumericRank(num)));
                    }

                    foreach(EHero hero in heros)
                    {
                        Cards.Add(new Card(suit, new HeroRank(hero)));
                    }
                }
            }
        }

        public bool HasAnyCard()
        {   
            return Cards.Count > 0;
        }

        public Card GetNextCard(Random random)
        {
            if (!HasAnyCard())
            {
                throw new Exception("no card in deckSet");
            }

            int randomIndex = random.Next(Cards.Count);
            Card randomCard = Cards[randomIndex];
            Cards.Remove(randomCard);
            return randomCard;
        }
    }
}
