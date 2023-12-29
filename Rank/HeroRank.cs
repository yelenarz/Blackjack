using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Rank
{
    public class HeroRank: BaseRank
    {
        public EHero Hero { get; private set; }

        public HeroRank(EHero hero)
        {
            Hero = hero;

            switch(hero){
                case EHero.Ace:
                    Value = 1;
                    break;

                case EHero.King:
                case EHero.Queen:
                case EHero.Jack:
                    Value = 10;
                    break;

                default:
                    throw new Exception(string.Format("unsupported EHero type = {0}", hero));
            }
        }
    }
}
