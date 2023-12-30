using Blackjack.Rank;
using System;
using System.Configuration;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Game game;

        int bet;
        int playerCardsCount, dealerCardsCount;

        PlayerDeckController dealerDeckController;
        PlayerDeckController playerDeckControllerMain;
        PlayerDeckController playerDeckControllerAdditional;

        public Form1()
        {
            game = new Game();
            InitializeComponent();
            dealerDeckController = new PlayerDeckController(
                dealerCard1, dealerCard2, dealerCard3, dealerCard4, dealerCard5, dealerCard6, dealerCard7
            );
            playerDeckControllerMain = new PlayerDeckController(
                playerCard1, playerCard2, playerCard3, playerCard4, playerCard5, playerCard6, playerCard7
            );
            playerDeckControllerAdditional = new PlayerDeckController(
                player2Card1, player2Card2, player2Card3, player2Card4, player2Card5, player2Card6, player2Card7
            );
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
                game.Dealer.Cards.Clear();//does not remove cards
                game.Player.Cards.Clear();
                dealerCardsCount = 1;
                playerDeckControllerMain.Clear();
                playerDeckControllerAdditional.Clear();
                dealerDeckController.Clear();
                newGameBox.Visible = true;
                label4.Visible = false;
                enterBetTextbox.Visible = false;
                game.Player.Money -= bet;
                betLabel.Text = "Your bet: " + bet.ToString();
                walletLabel.Text = "Your wallet: " + game.Player.Money.ToString();
                splitBtn.Visible = false;
                doubleDownBtn.Visible = false;
                enterBetTextbox.Text = "0";
            }
        }

        public void getCards(PictureBox Card1, PictureBox Card2, PictureBox DCard)
        {
            Random random = new Random();

            //Card card1 = game.DeckSet.GetNextCard(random);
            Card card1 = new Card(ESuit.CLUBS, new HeroRank(EHero.Jack));
            game.Player.AddCard(card1);
            //Card card2 = game.DeckSet.GetNextCard(random);
            Card card2 = new Card(ESuit.HEARTS, new HeroRank(EHero.Ace));
            game.Player.AddCard(card2);

            playerDeckControllerMain.ShowCard(card1);
            playerDeckControllerMain.ShowCard(card2);
            playerCountLabel.Text = "Your count: " + game.Player.GetSumValue().ToString();
            playerCountLabel2.Text = "Your count: " + game.Player2.GetSumValue().ToString();


            if (card1.Rank.IsSamePictureValue(card2.Rank))//checks only values 10 and king true
            {
                splitBtn.Visible = true;
            }

            Card dCard = game.DeckSet.GetNextCard(random);
            game.Dealer.AddCard(dCard);

            dealerDeckController.ShowCard(dCard);
            dealerCountLabel.Text = "Dealer's count: " + game.Dealer.GetSumValue().ToString();

            isGameOver();
        }

        public bool isGameOver()
        {
            CheckResults res = new CheckResults();
            res.checkResults(game);
            if (res.draw)
            {
                DialogResult result = MessageBox.Show("\nWould you like to play again? ", "It is a draw " + (bet).ToString(), MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    setNewGame();
                }
                else
                {
                    this.Close();
                }
                return true;
            }
            else if (res.bustDealer)
            {
                game.Player.Money += bet * 2;
                DialogResult result = MessageBox.Show("\nWould you like to play again? ", "Congratulations! You won " + (bet).ToString(), MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    setNewGame();
                }
                else
                {
                    this.Close();
                }
                return true;
            }
            else if (res.bustPlayer)
            {
                DialogResult result = MessageBox.Show("\nWould you like to play again? ", "You lost " + (bet).ToString(), MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    setNewGame();
                }
                else
                {
                    this.Close();
                }
                return true;
            }
            return false;
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
            Random random = new Random();

            Card card1 = game.DeckSet.GetNextCard(random);
            //Card card1 = new Card(ESuit.CLUBS, new HeroRank(EHero.Jack));
            game.Player.AddCard(card1);

            playerDeckControllerMain.ShowCard(card1);
            playerCountLabel.Text = "Your count: " + game.Player.GetSumValue().ToString();

            isGameOver();
        }

        private void splitBtn_Click(object sender, EventArgs e)
        {
            splitBtn.Visible = false;
            betLabel.Visible = false;
            playerCountLabel2.Visible = true;
            game.Player.Money -= bet;
            bet *= 2;
            walletLabel.Text = "Your wallet: " + game.Player.Money.ToString();
            hand1Bet1.Visible = true;
            hand2Bet1.Visible = true;
            hand1Bet1.Text = "Bet: " + (bet / 2).ToString();
            hand2Bet1.Text = "Bet: " + (bet / 2).ToString();

            Card last = game.Player.Cards[game.Player.Cards.Count - 1];
            game.Player.RemoveCard(last);
            game.Player2.AddCard(last);

            playerDeckControllerMain.ClearLastCard();
            playerDeckControllerAdditional.ShowCard(last);

            playerCountLabel.Text = "Your count: " + game.Player.GetSumValue().ToString();
            playerCountLabel2.Text = "Your count: " + game.Player2.GetSumValue().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stayBtn_Click(object sender, EventArgs e)
        {
            bool isGameOverVar = false;
            while (!isGameOverVar)
            {
                Random random = new Random();
                Card dCard = game.DeckSet.GetNextCard(random);
                game.Dealer.AddCard(dCard);
                dealerDeckController.ShowCard(dCard);
                dealerCountLabel.Text = "Dealer's count: " + game.Dealer.GetSumValue().ToString();
                isGameOverVar = isGameOver();
            }

        }
    }
}