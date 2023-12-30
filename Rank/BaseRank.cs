using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Rank
{
    //basis for for any rank of a card
    public abstract class BaseRank
    {
        public int Value { get; protected set; }

        //call for a function to check if the rank match(for split)
        public abstract bool IsSamePictureValue(BaseRank b);
    }
}
