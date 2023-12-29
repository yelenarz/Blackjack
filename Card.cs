using Blackjack.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public ESuit Suit { get; private set; }

        public BaseRank Rank { get; private set; }

        public Card(ESuit suit, BaseRank baseRank) {
            this.Suit = suit;  
            this.Rank = baseRank;
        }

        public string GetNameOfView()
        {
            NumericRank numericRank = Rank as NumericRank;
            if(numericRank != null)
            {
                return string.Format("_{0}_of_{1}", numericRank.Value, GetSuitName());
            }
            HeroRank heroRank = Rank as HeroRank;
            if(heroRank != null)
            {
                return string.Format("{0}_of_{1}", GetHeroName(heroRank.Hero), GetSuitName());
            }
            throw new Exception("unsupported rank");
        }

        private string GetSuitName()
        {
            switch (Suit)
            {
                case ESuit.SPADES:
                    return "spades";

                case ESuit.HEARTS:
                    return "hearts";

                case ESuit.CLUBS:
                    return "clubs";

                case ESuit.DIAMONDS:
                    return "diamonds";

                default:
                    throw new Exception(string.Format("unsupported suit: {0}", Suit));
            }
        }

        private string GetHeroName(EHero hero)
        {
            switch (hero)
            {
                case EHero.Ace:
                    return "ace";

                case EHero.King:
                    return "king";

                case EHero.Queen:
                    return "queen";

                case EHero.Jack:
                    return "jack";

                default:
                    throw new Exception(string.Format("unsupported hero: {0}", hero));
            }
        }
    }
}
