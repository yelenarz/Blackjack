using System;
using System.Configuration;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Game game;
        private CheckResults results;

        int bet;
        int playerCardsCount, dealerCardsCount;

        public Form1()
        {
            game = new Game();
            InitializeComponent();
        }

        public void setNewGame()
        {
            bet = 0;
            label4.Visible = true;
            enterBetTextbox.Visible = true;
            newGameBox.Visible = false;
            bet = int.Parse(enterBetTextbox.Text);

            if (bet < 2 || bet > 50)
            {
                label4.Text = "Bet needs to be >=2 or <=50";
            }
            else
            {
                game.Dealer.Cards.Clear();
                game.Player.Cards.Clear();
                dealerCardsCount = 1;
                dealerCard3.Image = null;
                dealerCard4.Image = null;
                dealerCard5.Image = null;
                dealerCard6.Image = null;
                newGameBox.Visible = true;
                label4.Visible = false;
                enterBetTextbox.Visible = false;
                betLabel.Text = "Your bet: " + bet.ToString();
                game.Player.Money -= bet;
                walletLabel.Text = "Your wallet: " + game.Player.Money.ToString();
                splitBtn.Visible = false;
                doubleDownBtn.Visible = false;
                enterBetTextbox.Text = "0";
            }
        }

        public void getCards(PictureBox Card1, PictureBox Card2, PictureBox DCard)
        {
            Random random = new Random();

            Card card1 = game.DeckSet.GetNextCard(random);
            game.Player.AddCard(card1);
            Card card2 = game.DeckSet.GetNextCard(random);
            game.Player.AddCard(card2);

            Card1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(card1.GetNameOfView());
            Card2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(card2.GetNameOfView());
            playerCountLabel.Text = "Your count: " + game.Player.GetSumValue().ToString();

            if (card1.Rank.Value == card2.Rank.Value)//checks only values 10 and king true
            {
                splitBtn.Visible = true;
            }

            Card dCard = game.DeckSet.GetNextCard(random);
            game.Dealer.AddCard(dCard);

            DCard.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(dCard.GetNameOfView());
            dealerCountLabel.Text = "Dealer's count: " + game.Dealer.GetSumValue().ToString();

            gameOver();
        }

        public void gameOver()
        {
            results.checkResults(game);
            if ()
                                bet *= 2;
            game.Player.Money += bet;
            DialogResult result = MessageBox.Show("\nWould you like to play again? ", "Congratulations! You won " + (bet).ToString(), MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                setNewGame();
            }
            else
            {
                this.Close();
            }
        }
        
        private void enterBetTextbox_TextChanged_1(object sender, EventArgs e)
        {
            startGameBtn.Enabled = true;
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            setNewGame();
            getCards(playerCard1, playerCard2, dealerCard1);
        }

        private void takeCardBtn_Click(object sender, EventArgs e)
        {
            getCards(playerCard3, playerCard4, dealerCard2);
        }

        private void splitBtn_Click(object sender, EventArgs e)
        {
            betLabel.Visible = false;
            game.Player.Money -= bet;
            bet *= 2;
            walletLabel.Text = "Your wallet: " + game.Player.Money.ToString();
            hand1Bet1.Visible = true;
            hand2Bet1.Visible = true;
            hand1Bet1.Text = "Bet: " + (bet / 2).ToString();
            hand2Bet1.Text = "Bet: " + (bet / 2).ToString();
            getCards(pictureBox4, pictureBox5, dealerCard2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stayBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Card dCard = game.DeckSet.GetNextCard(random);
            game.Dealer.AddCard(dCard);
            dealerCountLabel.Text = "Dealer's count: " + game.Dealer.GetSumValue().ToString();

            switch (dealerCardsCount)
            {
                case 1:
                    dealerCard2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(dCard.GetNameOfView());
                    dealerCardsCount++;
                    checkResult();
                    break;
                case 2:
                    dealerCard3.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(dCard.GetNameOfView());
                    dealerCardsCount++;
                    checkResult();
                    break;
                case 3:
                    dealerCard4.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(dCard.GetNameOfView());
                    dealerCardsCount++;
                    checkResult();
                    break;
                case 4:
                    dealerCard5.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(dCard.GetNameOfView());
                    dealerCardsCount++;
                    checkResult();
                    break;
                case 5:
                    dealerCard6.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(dCard.GetNameOfView());
                    dealerCardsCount++;
                    checkResult();
                    break;
                default:
                    break;
            }
        }

       
    }
}