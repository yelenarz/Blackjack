using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    /*
     * In this class functions add cards in the new pictureBox for player and dealer
     * and delete them at the end of the game
     */
    public class PlayerDeckController
    {
        //Maximum 8 cards can be filled in the pictureboxes
        PictureBox card1;
        PictureBox card2;
        PictureBox card3;
        PictureBox card4;
        PictureBox card5;
        PictureBox card6;
        PictureBox card7;
        PictureBox card8;

        public int count; //counts how many pictureboxes are filled already

        public PlayerDeckController(PictureBox card1, PictureBox card2, PictureBox card3, PictureBox card4, PictureBox card5, PictureBox card6, PictureBox card7, PictureBox card8)
        {
            this.card1 = card1;
            this.card2 = card2;
            this.card3 = card3;
            this.card4 = card4;
            this.card5 = card5;
            this.card6 = card6;
            this.card7 = card7;
            this.card8 = card8;            
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
            card8.Image = null;
        }

        //Shows card in the next picture box
        public void ShowCard(Card card)
        {
            PictureBox picture = this.GetNextPictureBox(count);
            picture.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(card.GetNameOfView());
            count++;
        }

        /*
         * This section is responsible for the split functionality. 
         * It involves removing the last card from the first hand and transferring 
         * it to another hand. Visually, it will appear as one card positioned under another. 
         */
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
                case 7:
                    return card8;
                default:
                    throw new Exception("no space");
            }
        }
    }
}
