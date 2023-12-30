using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class CheckResults
    {
        public bool bustDealer = false, bustPlayer = false, draw=false;
        public void checkResults(Game game)
        {
            if (game.Dealer.GetSumValue() >= 17 || game.Player.GetSumValue() > 21)
            {
                if (game.Dealer.GetSumValue() > 21 && game.Player.GetSumValue() < 21)
                {
                    bustDealer = true;
                }
                else if (game.Dealer.GetSumValue() == game.Player.GetSumValue())
                {
                    draw = true;
                }
                else if (game.Player.GetSumValue() > 21 && game.Dealer.GetSumValue() < 21)
                {
                    bustPlayer = true;
                }
                else
                {
                    if (game.Player.GetSumValue() < game.Dealer.GetSumValue())
                    {
                        bustPlayer = true;
                    }
                    else
                    {
                        bustDealer = true;
                    }
                }
            }
            
        }
    }
}
