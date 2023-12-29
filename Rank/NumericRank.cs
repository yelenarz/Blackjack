using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Rank
{
    public class NumericRank: BaseRank
    {
        public NumericRank(int value) {
            if(value < 2) throw new ArgumentOutOfRangeException("value");
            if(value > 10) throw new ArgumentOutOfRangeException("value");
            Value = value;
        }
    }
}
