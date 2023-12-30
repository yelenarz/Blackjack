using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class PlayerDeckController
    {
        PictureBox card1;
        PictureBox card2;
        PictureBox card3;
        PictureBox card4;
        PictureBox card5;
        PictureBox card6;
        PictureBox card7;

        public int count;

        public PlayerDeckController(PictureBox card1, PictureBox card2, PictureBox card3, PictureBox card4, PictureBox card5, PictureBox card6, PictureBox card7)
        {
            this.card1 = card1;
            this.card2 = card2;
            this.card3 = card3;
            this.card4 = card4;
            this.card5 = card5;
            this.card6 = card6;
            this.card7 = card7;
            this.count = 0;
        }

        public void Clear()
        {
            card1.Image = null;
            card2.Image = null;
            card3.Image = null;
            card4.Image = null;
            card5.Image = null;
            card6.Image = null;
            card7.Image = null;
        }

        public void ShowCard(Card card)
        {
            PictureBox picture = this.GetNextPictureBox(count);
            picture.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(card.GetNameOfView());
            count++;
        }

        internal void ClearLastCard()
        {
            PictureBox picture = this.GetNextPictureBox(count-1);
            picture.Image = null;
            count--;
        }

        private PictureBox GetNextPictureBox(int currentCount)
        {
            switch (currentCount)
            {
                case 0:
                    return card1;
                case 1:
                    return card2;
                case 2:
                    return card3;
                case 3:
                    return card4;
                case 4:
                    return card5;
                case 5:
                    return card6;
                case 6:
                    return card7;
                default:
                    throw new Exception("no space");
            }
        }
    }
}
