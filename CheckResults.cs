using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class CheckResults
    {
        bool bustDealer = false, bustPlayer = false;
        public void checkResults(Game game) 
        {
            if (game.Dealer.GetSumValue() >= 17)
            {
                if (game.Dealer.GetSumValue() > 21 && game.Player.GetSumValue() < 21)
                {
                    bustDealer = true;
                }
                else if (game.Dealer.GetSumValue() == game.Player.GetSumValue())
                {
                    bustPlayer = true;
                    bustDealer = true;
                }
            }
            if (game.Player.GetSumValue() > 21)
            {
                bustPlayer = true;
            }
            if (bustDealer && bustPlayer == false)
            {
            
    }
}
