namespace Blackjack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playerCountLabel = new Label();
            startGameBtn = new Button();
            dealerCard1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            startANewGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            WelcomeLabel = new Label();
            playerCard1 = new PictureBox();
            dealerCountLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            walletLabel = new Label();
            playerCard2 = new PictureBox();
            takeCardBtn = new Button();
            stayBtn = new Button();
            splitBtn = new Button();
            doubleDownBtn = new Button();
            player2Card1 = new PictureBox();
            player2Card2 = new PictureBox();
            player2Card3 = new PictureBox();
            player2Card4 = new PictureBox();
            player2Card5 = new PictureBox();
            dealerCard2 = new PictureBox();
            dealerCard3 = new PictureBox();
            dealerCard4 = new PictureBox();
            dealerCard5 = new PictureBox();
            dealerCard6 = new PictureBox();
            player2Card6 = new PictureBox();
            player2Card7 = new PictureBox();
            playerCard3 = new PictureBox();
            playerCard4 = new PictureBox();
            betLabel = new Label();
            hand1Bet1 = new Label();
            hand2Bet1 = new Label();
            newGameBox = new GroupBox();
            playerCountLabel2 = new Label();
            playerCard7 = new PictureBox();
            playerCard6 = new PictureBox();
            playerCard5 = new PictureBox();
            dealerCard7 = new PictureBox();
            choiceGroupBox = new GroupBox();
            label4 = new Label();
            enterBetTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dealerCard1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2Card7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard4).BeginInit();
            newGameBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerCard7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard7).BeginInit();
            choiceGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // playerCountLabel
            // 
            playerCountLabel.AutoSize = true;
            playerCountLabel.Location = new Point(37, 271);
            playerCountLabel.Name = "playerCountLabel";
            playerCountLabel.Size = new Size(70, 20);
            playerCountLabel.TabIndex = 10;
            playerCountLabel.Text = "Count =0";
            // 
            // startGameBtn
            // 
            startGameBtn.Enabled = false;
            startGameBtn.Location = new Point(406, 120);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(165, 27);
            startGameBtn.TabIndex = 1;
            startGameBtn.Text = "Start a new game";
            startGameBtn.UseVisualStyleBackColor = true;
            startGameBtn.Click += startGameBtn_Click;
            // 
            // dealerCard1
            // 
            dealerCard1.Location = new Point(206, 44);
            dealerCard1.Name = "dealerCard1";
            dealerCard1.Size = new Size(41, 67);
            dealerCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerCard1.TabIndex = 3;
            dealerCard1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(998, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startANewGameToolStripMenuItem, exitToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(62, 24);
            gameToolStripMenuItem.Text = "Game";
            // 
            // startANewGameToolStripMenuItem
            // 
            startANewGameToolStripMenuItem.Name = "startANewGameToolStripMenuItem";
            startANewGameToolStripMenuItem.Size = new Size(208, 26);
            startANewGameToolStripMenuItem.Text = "Start a new game";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(208, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(49, 24);
            infoToolStripMenuItem.Text = "Info";
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(290, 45);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(447, 32);
            WelcomeLabel.TabIndex = 7;
            WelcomeLabel.Text = "Welcome to Black Jack game!";
            // 
            // playerCard1
            // 
            playerCard1.Location = new Point(206, 224);
            playerCard1.Name = "playerCard1";
            playerCard1.Size = new Size(41, 67);
            playerCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCard1.TabIndex = 8;
            playerCard1.TabStop = false;
            // 
            // dealerCountLabel
            // 
            dealerCountLabel.AutoSize = true;
            dealerCountLabel.Location = new Point(37, 91);
            dealerCountLabel.Name = "dealerCountLabel";
            dealerCountLabel.Size = new Size(70, 20);
            dealerCountLabel.TabIndex = 9;
            dealerCountLabel.Text = "Count =0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 15;
            label1.Text = "Dealer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 224);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 16;
            label2.Text = "Player";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 16);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 17;
            label3.Text = "Your choices:";
            // 
            // walletLabel
            // 
            walletLabel.AutoSize = true;
            walletLabel.Location = new Point(16, 306);
            walletLabel.Name = "walletLabel";
            walletLabel.Size = new Size(115, 20);
            walletLabel.TabIndex = 18;
            walletLabel.Text = "Your Wallet: 300";
            // 
            // playerCard2
            // 
            playerCard2.Location = new Point(273, 224);
            playerCard2.Name = "playerCard2";
            playerCard2.Size = new Size(41, 67);
            playerCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCard2.TabIndex = 19;
            playerCard2.TabStop = false;
            // 
            // takeCardBtn
            // 
            takeCardBtn.Location = new Point(70, 40);
            takeCardBtn.Name = "takeCardBtn";
            takeCardBtn.Size = new Size(94, 29);
            takeCardBtn.TabIndex = 23;
            takeCardBtn.Text = "Take cards";
            takeCardBtn.UseVisualStyleBackColor = true;
            takeCardBtn.Click += takeCardBtn_Click;
            // 
            // stayBtn
            // 
            stayBtn.Location = new Point(70, 75);
            stayBtn.Name = "stayBtn";
            stayBtn.Size = new Size(94, 29);
            stayBtn.TabIndex = 24;
            stayBtn.Text = "Stay";
            stayBtn.UseVisualStyleBackColor = true;
            stayBtn.Click += stayBtn_Click;
            // 
            // splitBtn
            // 
            splitBtn.Location = new Point(70, 110);
            splitBtn.Name = "splitBtn";
            splitBtn.Size = new Size(94, 29);
            splitBtn.TabIndex = 25;
            splitBtn.Text = "Split";
            splitBtn.UseVisualStyleBackColor = true;
            splitBtn.Visible = false;
            splitBtn.Click += splitBtn_Click;
            // 
            // doubleDownBtn
            // 
            doubleDownBtn.Location = new Point(39, 145);
            doubleDownBtn.Name = "doubleDownBtn";
            doubleDownBtn.Size = new Size(148, 29);
            doubleDownBtn.TabIndex = 26;
            doubleDownBtn.Text = "Double Down";
            doubleDownBtn.UseVisualStyleBackColor = true;
            doubleDownBtn.Visible = false;
            doubleDownBtn.Click += doubleDownBtn_Click;
            // 
            // player2Card1
            // 
            player2Card1.Location = new Point(206, 320);
            player2Card1.Name = "player2Card1";
            player2Card1.Size = new Size(41, 67);
            player2Card1.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card1.TabIndex = 30;
            player2Card1.TabStop = false;
            // 
            // player2Card2
            // 
            player2Card2.Location = new Point(273, 320);
            player2Card2.Name = "player2Card2";
            player2Card2.Size = new Size(41, 67);
            player2Card2.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card2.TabIndex = 31;
            player2Card2.TabStop = false;
            // 
            // player2Card3
            // 
            player2Card3.Location = new Point(339, 320);
            player2Card3.Name = "player2Card3";
            player2Card3.Size = new Size(41, 67);
            player2Card3.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card3.TabIndex = 32;
            player2Card3.TabStop = false;
            // 
            // player2Card4
            // 
            player2Card4.Location = new Point(410, 320);
            player2Card4.Name = "player2Card4";
            player2Card4.Size = new Size(41, 67);
            player2Card4.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card4.TabIndex = 33;
            player2Card4.TabStop = false;
            // 
            // player2Card5
            // 
            player2Card5.Location = new Point(473, 320);
            player2Card5.Name = "player2Card5";
            player2Card5.Size = new Size(41, 67);
            player2Card5.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card5.TabIndex = 34;
            player2Card5.TabStop = false;
            // 
            // dealerCard2
            // 
            dealerCard2.Location = new Point(273, 44);
            dealerCard2.Name = "dealerCard2";
            dealerCard2.Size = new Size(41, 67);
            dealerCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerCard2.TabIndex = 35;
            dealerCard2.TabStop = false;
            // 
            // dealerCard3
            // 
            dealerCard3.Location = new Point(339, 44);
            dealerCard3.Name = "dealerCard3";
            dealerCard3.Size = new Size(41, 67);
            dealerCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerCard3.TabIndex = 36;
            dealerCard3.TabStop = false;
            // 
            // dealerCard4
            // 
            dealerCard4.Location = new Point(410, 44);
            dealerCard4.Name = "dealerCard4";
            dealerCard4.Size = new Size(41, 67);
            dealerCard4.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerCard4.TabIndex = 37;
            dealerCard4.TabStop = false;
            // 
            // dealerCard5
            // 
            dealerCard5.Location = new Point(475, 44);
            dealerCard5.Name = "dealerCard5";
            dealerCard5.Size = new Size(41, 67);
            dealerCard5.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerCard5.TabIndex = 38;
            dealerCard5.TabStop = false;
            // 
            // dealerCard6
            // 
            dealerCard6.Location = new Point(545, 44);
            dealerCard6.Name = "dealerCard6";
            dealerCard6.Size = new Size(41, 67);
            dealerCard6.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerCard6.TabIndex = 39;
            dealerCard6.TabStop = false;
            // 
            // player2Card6
            // 
            player2Card6.Location = new Point(545, 315);
            player2Card6.Name = "player2Card6";
            player2Card6.Size = new Size(41, 67);
            player2Card6.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card6.TabIndex = 41;
            player2Card6.TabStop = false;
            // 
            // player2Card7
            // 
            player2Card7.Location = new Point(622, 315);
            player2Card7.Name = "player2Card7";
            player2Card7.Size = new Size(41, 67);
            player2Card7.SizeMode = PictureBoxSizeMode.StretchImage;
            player2Card7.TabIndex = 42;
            player2Card7.TabStop = false;
            // 
            // playerCard3
            // 
            playerCard3.Location = new Point(339, 224);
            playerCard3.Name = "playerCard3";
            playerCard3.Size = new Size(41, 67);
            playerCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCard3.TabIndex = 44;
            playerCard3.TabStop = false;
            // 
            // playerCard4
            // 
            playerCard4.Location = new Point(410, 224);
            playerCard4.Name = "playerCard4";
            playerCard4.Size = new Size(41, 67);
            playerCard4.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCard4.TabIndex = 45;
            playerCard4.TabStop = false;
            // 
            // betLabel
            // 
            betLabel.BackColor = Color.FromArgb(255, 128, 128);
            betLabel.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            betLabel.ForeColor = SystemColors.ActiveCaptionText;
            betLabel.Location = new Point(4, 178);
            betLabel.Name = "betLabel";
            betLabel.Size = new Size(150, 29);
            betLabel.TabIndex = 46;
            betLabel.Text = "Your bet:";
            betLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hand1Bet1
            // 
            hand1Bet1.AutoSize = true;
            hand1Bet1.Location = new Point(183, 297);
            hand1Bet1.Name = "hand1Bet1";
            hand1Bet1.Size = new Size(34, 20);
            hand1Bet1.TabIndex = 47;
            hand1Bet1.Text = "Bet:";
            hand1Bet1.Visible = false;
            // 
            // hand2Bet1
            // 
            hand2Bet1.AutoSize = true;
            hand2Bet1.Location = new Point(183, 390);
            hand2Bet1.Name = "hand2Bet1";
            hand2Bet1.Size = new Size(34, 20);
            hand2Bet1.TabIndex = 48;
            hand2Bet1.Text = "Bet:";
            hand2Bet1.Visible = false;
            // 
            // newGameBox
            // 
            newGameBox.Controls.Add(playerCountLabel2);
            newGameBox.Controls.Add(playerCard7);
            newGameBox.Controls.Add(playerCard6);
            newGameBox.Controls.Add(playerCard5);
            newGameBox.Controls.Add(dealerCard7);
            newGameBox.Controls.Add(choiceGroupBox);
            newGameBox.Controls.Add(playerCard3);
            newGameBox.Controls.Add(dealerCard1);
            newGameBox.Controls.Add(playerCard1);
            newGameBox.Controls.Add(dealerCountLabel);
            newGameBox.Controls.Add(hand2Bet1);
            newGameBox.Controls.Add(betLabel);
            newGameBox.Controls.Add(playerCountLabel);
            newGameBox.Controls.Add(hand1Bet1);
            newGameBox.Controls.Add(playerCard4);
            newGameBox.Controls.Add(label1);
            newGameBox.Controls.Add(label2);
            newGameBox.Controls.Add(player2Card7);
            newGameBox.Controls.Add(walletLabel);
            newGameBox.Controls.Add(playerCard2);
            newGameBox.Controls.Add(player2Card6);
            newGameBox.Controls.Add(dealerCard6);
            newGameBox.Controls.Add(player2Card1);
            newGameBox.Controls.Add(player2Card3);
            newGameBox.Controls.Add(player2Card5);
            newGameBox.Controls.Add(dealerCard5);
            newGameBox.Controls.Add(player2Card4);
            newGameBox.Controls.Add(player2Card2);
            newGameBox.Controls.Add(dealerCard4);
            newGameBox.Controls.Add(dealerCard3);
            newGameBox.Controls.Add(dealerCard2);
            newGameBox.Location = new Point(27, 153);
            newGameBox.Name = "newGameBox";
            newGameBox.Size = new Size(894, 415);
            newGameBox.TabIndex = 51;
            newGameBox.TabStop = false;
            newGameBox.Visible = false;
            // 
            // playerCountLabel2
            // 
            playerCountLabel2.AutoSize = true;
            playerCountLabel2.Location = new Point(37, 346);
            playerCountLabel2.Name = "playerCountLabel2";
            playerCountLabel2.Size = new Size(70, 20);
            playerCountLabel2.TabIndex = 80;
            playerCountLabel2.Text = "Count =0";
            playerCountLabel2.Visible = false;
            // 
            // playerCard7
            // 
            playerCard7.Location = new Point(622, 224);
            playerCard7.Name = "playerCard7";
            playerCard7.Size = new Size(41, 67);
            playerCard7.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCard7.TabIndex = 79;
            playerCard7.TabStop = false;
            // 
            // playerCard6
            // 
            playerCard6.Location = new Point(545, 224);
            playerCard6.Name = "playerCard6";
            playerCard6.Size = new Size(41, 67);
            playerCard6.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCard6.TabIndex = 78;
            playerCard6.TabStop = false;
            // 
            // playerCard5
            // 
            playerCard5.Location = new Point(475, 224);
            playerCard5.Name = "playerCard5";
            playerCard5.Size = new Size(41, 67);
            playerCard5.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCard5.TabIndex = 77;
            playerCard5.TabStop = false;
            // 
            // dealerCard7
            // 
            dealerCard7.Location = new Point(622, 44);
            dealerCard7.Name = "dealerCard7";
            dealerCard7.Size = new Size(41, 67);
            dealerCard7.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerCard7.TabIndex = 76;
            dealerCard7.TabStop = false;
            // 
            // choiceGroupBox
            // 
            choiceGroupBox.Controls.Add(takeCardBtn);
            choiceGroupBox.Controls.Add(doubleDownBtn);
            choiceGroupBox.Controls.Add(splitBtn);
            choiceGroupBox.Controls.Add(stayBtn);
            choiceGroupBox.Controls.Add(label3);
            choiceGroupBox.Location = new Point(692, 17);
            choiceGroupBox.Name = "choiceGroupBox";
            choiceGroupBox.Size = new Size(218, 195);
            choiceGroupBox.TabIndex = 75;
            choiceGroupBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 90);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 76;
            label4.Text = "How much you want to bet?";
            // 
            // enterBetTextbox
            // 
            enterBetTextbox.Location = new Point(526, 87);
            enterBetTextbox.Name = "enterBetTextbox";
            enterBetTextbox.Size = new Size(125, 27);
            enterBetTextbox.TabIndex = 77;
            enterBetTextbox.TextChanged += enterBetTextbox_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 678);
            Controls.Add(enterBetTextbox);
            Controls.Add(label4);
            Controls.Add(newGameBox);
            Controls.Add(startGameBtn);
            Controls.Add(WelcomeLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Blackjack";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dealerCard1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card3).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card4).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard6).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card6).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2Card7).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard4).EndInit();
            newGameBox.ResumeLayout(false);
            newGameBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerCard7).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard6).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard7).EndInit();
            choiceGroupBox.ResumeLayout(false);
            choiceGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startGameBtn;
        private PictureBox dealerCard1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem startANewGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private Label WelcomeLabel;
        private PictureBox playerCard1;
        private Label dealerCountLabel;
        private Label playerCountLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label walletLabel;
        private PictureBox playerCard2;
        private Label currentBetLabel;
        private Button takeCardBtn;
        private Button stayBtn;
        private Button splitBtn;
        private Button doubleDownBtn;
        private PictureBox player2Card7;
        private PictureBox player2Card1;
        private PictureBox player2Card2;
        private PictureBox player2Card3;
        private PictureBox player2Card4;
        private PictureBox player2Card5;
        private PictureBox dealerCard2;
        private PictureBox dealerCard3;
        private PictureBox dealerCard4;
        private PictureBox dealerCard5;
        private PictureBox dealerCard6;
        private PictureBox player2Card6;
        private PictureBox playerCard3;
        private PictureBox playerCard4;
        private Label betLabel;
        private Label hand1Bet1;
        private Label hand2Bet1;
        private GroupBox newGameBox;
        private GroupBox choiceGroupBox;
        private Label label4;
        private TextBox enterBetTextbox;
        private PictureBox playerCard7;
        private PictureBox playerCard6;
        private PictureBox playerCard5;
        private PictureBox dealerCard7;
        private Label playerCountLabel2;
    }
}