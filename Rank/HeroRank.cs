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

        private bool maxMode;
        public bool MaxMode { 
            get { return maxMode; } 
            set { maxMode = value; refreshValue(); }
        }
        public HeroRank(EHero hero)
        {
            Hero = hero;
            this.refreshValue();            
        }

        private void refreshValue()
        {
            switch (this.Hero)
            {
                case EHero.Ace:
                    Value = MaxMode ? 11 : 1;
                    break;

                case EHero.King:
                case EHero.Queen:
                case EHero.Jack:
                    Value = 10;
                    break;

                default:
                    throw new Exception(string.Format("unsupported EHero type = {0}", this.Hero));
            }
        }

        public override bool IsSamePictureValue(BaseRank b)
        {
            HeroRank anotherHero = b as HeroRank;
            if (anotherHero == null) return false;
            return this.Hero == anotherHero.Hero;
        }
    }
}
