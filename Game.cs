using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Game
    {
        public DeckSet DeckSet { get; private set; }

        public Player Player { get; private set; }

        public Player Player2 { get; private set; }
        public Dealer Dealer { get; private set; }

        public Game()
        {
            DeckSet = new DeckSet(6);
            Player = new Player(300);
            Player2 = new Player(0);
            Dealer = new Dealer();
        }
    }
}

