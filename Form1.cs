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

        //Initialize pictureBoxes
        PlayerDeckController dealerDeckController;//Dealer
        PlayerDeckController playerDeckControllerMain;//Hand 1
        PlayerDeckController playerDeckControllerAdditional;//Hand 2

        //Initialize form and create new pictureboxes for cards
        public Form1()
        {
            game = new Game();
            InitializeComponent();
            dealerDeckController = new PlayerDeckController(
                dealerCard1, dealerCard2, dealerCard3, dealerCard4, dealerCard5, dealerCard6, dealerCard7, dealerCard8
            );
            playerDeckControllerMain = new PlayerDeckController(
                playerCard1, playerCard2, playerCard3, playerCard4, playerCard5, playerCard6, playerCard7, playerCard8
            );
            playerDeckControllerAdditional = new PlayerDeckController(
                player2Card1, player2Card2, player2Card3, player2Card4, player2Card5, player2Card6, player2Card7, player2Card8
            );
        }

        //This function checks in the user entered a valid bet and sets an interface to begin a game
        public void setNewGame()
        {
            //Initialize interface, variables to accept from the user a bet
            bet = 0;
            label4.Visible = true;
            enterBetTextbox.Visible = true;
            newGameBox.Visible = false;
            bet = int.Parse(enterBetTextbox.Text);

            //Check if the bet is within a range
            if (bet < 2 || bet > 100)
            {
                label4.Text = "Bet needs to be >=2 or <=100";
            }
            else
            {
                //Initialize interface of the Form for the begging of the game considering given get
                game.Dealer.Cards.Clear();
                game.Player.Cards.Clear();
                playerDeckControllerMain.Clear();
                playerDeckControllerAdditional.Clear();
                dealerDeckController.Clear();
                newGameBox.Visible = true;
                label4.Visible = false;
                enterBetTextbox.Visible = false;
                game.Player.Money -= bet;
                betLabel.Visible = true;
                betLabel.Text = "Your bet: " + bet.ToString();
                walletLabel.Text = "Your wallet: " + game.Player.Money.ToString();
                splitBtn.Visible = false;
                doubleDownBtn.Visible = false;
                enterBetTextbox.Text = "0";
                playerDeckControllerMain.count = 0;
                playerDeckControllerAdditional.count = 0;
                dealerDeckController.count = 0;
                hand1Bet1.Visible = false;
                hand2Bet1.Visible = false;
            }
        }

        /*
         * This function calls for two random cards for the user and one for the dealer, prints them
         * calls a function to check if the ranks of two user's cards are the same for a split option
         * checks if the total of user's cards is 9, 10 or 11 for the double down option
        */
        public void getCards(PictureBox Card1, PictureBox Card2, PictureBox DCard)
        {
            Random random = new Random();

            Card card1 = game.DeckSet.GetNextCard(random);
            game.Player.AddCard(card1);

            Card card2 = game.DeckSet.GetNextCard(random);
            game.Player.AddCard(card2);

            playerDeckControllerMain.ShowCard(card1);
            playerDeckControllerMain.ShowCard(card2);
            playerCountLabel.Text = "Your count: " + game.Player.GetSumValue().ToString();
            playerCountLabel2.Text = "Your count: " + game.Player2.GetSumValue().ToString();


            if (card1.Rank.IsSamePictureValue(card2.Rank))
            {
                splitBtn.Visible = true;
            }
            int playerSum = game.Player.GetSumValue();
            if (playerSum >= 9 && playerSum <= 11)
            {
                doubleDownBtn.Visible = true;
            }

            Card dCard = game.DeckSet.GetNextCard(random);
            game.Dealer.AddCard(dCard);

            dealerDeckController.ShowCard(dCard);
            dealerCountLabel.Text = "Dealer's count: " + game.Dealer.GetSumValue().ToString();

            isGameOver();
        }

        /*
         * This function calls another function (checkResults(game)) to determine if the game can be concluded. If the condition is met,
         * it updates the user on the outcome and adjusts their gains or losses from the bet. Additionally, 
         * it checks whether the user has enough money to start a new game.
         */
        public bool isGameOver()
        {
            CheckResults res = new CheckResults();
            res.checkResults(game);
            if (res.draw)
            {
                //Check if user has enough money to start a new game
                if (game.Player.Money <= 1)
                {
                    DialogResult result = MessageBox.Show("\nYou lost and do not have money to play " + MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("\nWould you like to play again? ", "It is a draw. You lost " + (bet).ToString(), MessageBoxButtons.YesNo);
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
            }
            else if (res.blackJack)
            {
                game.Player.Money += (int)(bet * 2.5);
                walletLabel.Text = "Your wallet " + game.Player.Money;
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
            else if (res.bustDealer)
            {
                game.Player.Money += bet * 2;
                walletLabel.Text = "Your wallet " + game.Player.Money;
                DialogResult result = MessageBox.Show("\nWould you like to play again? ", "Congratulations! You won " + (bet * 2).ToString(), MessageBoxButtons.YesNo);
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
                //Check if user has enough money to start a new game
                if (game.Player.Money <= 1)
                {
                    DialogResult result = MessageBox.Show("\nYou lost and do not have money to play " + MessageBoxButtons.OK);
                    if (result== DialogResult.OK)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
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

        /*
         * This function call will give one random card to a player,
         * update count and check if the game can be over.
         */
        private void takeCardBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Card card1 = game.DeckSet.GetNextCard(random);
            game.Player.AddCard(card1);

            playerDeckControllerMain.ShowCard(card1);
            playerCountLabel.Text = "Your count: " + game.Player.GetSumValue().ToString();

            isGameOver();
        }

        //This function is not complete, it does split first two cards in two hands, but
        //it will play only with the first hand until the game is over
        private void splitBtn_Click(object sender, EventArgs e)
        {
            //Initializing interface in the form for the second hand, updating wallet and bet
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

            //Remove one card from one hand and add it to another hand
            Card last = game.Player.Cards[game.Player.Cards.Count - 1];
            game.Player.RemoveCard(last);
            game.Player2.AddCard(last);

            playerDeckControllerMain.ClearLastCard();
            playerDeckControllerAdditional.ShowCard(last);

            playerCountLabel.Text = "Your count: " + game.Player.GetSumValue().ToString();
            playerCountLabel2.Text = "Your count: " + game.Player2.GetSumValue().ToString();

        }

        private void stayBtn_Click(object sender, EventArgs e)
        {
            this.dealerPlay();//Only dealer will get cards
        }

        // This function deals cards to the dealer until the game is over, as determined by the isGameOver() condition.
        private void dealerPlay()
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

        //In this function the bet, wallet will be updated and user will take only one card
        private void doubleDownBtn_Click(object sender, EventArgs e)
        {
            doubleDownBtn.Visible = false; //reasure user will not press it again

            game.Player.Money -= bet;
            bet *= 2;
            walletLabel.Text = "Your wallet: " + game.Player.Money.ToString();

            //Give only one random card for a player
            Random random = new Random();
            Card playerCard = game.DeckSet.GetNextCard(random);
            game.Player.AddCard(playerCard);
            playerDeckControllerMain.ShowCard(playerCard);
            
            //Keep taking cards for the dealer until the game is over
            bool res = isGameOver();
            if (!res)
            {
                this.dealerPlay();
            }
        }

        private void startANewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setNewGame();
            getCards(playerCard1, playerCard2, dealerCard1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game was designed by Yelena Razzhivina");
        }
    }
}