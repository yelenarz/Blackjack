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
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            dealerCard2 = new PictureBox();
            dealerCard3 = new PictureBox();
            dealerCard4 = new PictureBox();
            dealerCard5 = new PictureBox();
            dealerCard6 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            playerCard3 = new PictureBox();
            playerCard4 = new PictureBox();
            betLabel = new Label();
            hand1Bet1 = new Label();
            hand2Bet1 = new Label();
            hand1Bet2 = new Label();
            hand2Bet2 = new Label();
            newGameBox = new GroupBox();
            choiceGroupBox = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox20 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox27 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            enterBetTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dealerCard1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard4).BeginInit();
            newGameBox.SuspendLayout();
            choiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            playerCard1.Location = new Point(249, 224);
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
            playerCard2.Location = new Point(402, 224);
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
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(155, 315);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(249, 317);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 67);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(355, 315);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 67);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(437, 315);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 67);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 33;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(564, 315);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(41, 67);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 34;
            pictureBox8.TabStop = false;
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
            // pictureBox15
            // 
            pictureBox15.Location = new Point(636, 315);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(41, 67);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 41;
            pictureBox15.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(762, 315);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(830, 315);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // playerCard3
            // 
            playerCard3.Location = new Point(564, 224);
            playerCard3.Name = "playerCard3";
            playerCard3.Size = new Size(41, 67);
            playerCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            playerCard3.TabIndex = 44;
            playerCard3.TabStop = false;
            // 
            // playerCard4
            // 
            playerCard4.Location = new Point(762, 218);
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
            hand1Bet1.Location = new Point(198, 300);
            hand1Bet1.Name = "hand1Bet1";
            hand1Bet1.Size = new Size(34, 20);
            hand1Bet1.TabIndex = 47;
            hand1Bet1.Text = "Bet:";
            hand1Bet1.Visible = false;
            // 
            // hand2Bet1
            // 
            hand2Bet1.AutoSize = true;
            hand2Bet1.Location = new Point(402, 294);
            hand2Bet1.Name = "hand2Bet1";
            hand2Bet1.Size = new Size(34, 20);
            hand2Bet1.TabIndex = 48;
            hand2Bet1.Text = "Bet:";
            hand2Bet1.Visible = false;
            // 
            // hand1Bet2
            // 
            hand1Bet2.AutoSize = true;
            hand1Bet2.Location = new Point(596, 294);
            hand1Bet2.Name = "hand1Bet2";
            hand1Bet2.Size = new Size(34, 20);
            hand1Bet2.TabIndex = 49;
            hand1Bet2.Text = "Bet:";
            hand1Bet2.Visible = false;
            // 
            // hand2Bet2
            // 
            hand2Bet2.AutoSize = true;
            hand2Bet2.Location = new Point(793, 294);
            hand2Bet2.Name = "hand2Bet2";
            hand2Bet2.Size = new Size(34, 20);
            hand2Bet2.TabIndex = 50;
            hand2Bet2.Text = "Bet:";
            hand2Bet2.Visible = false;
            // 
            // newGameBox
            // 
            newGameBox.Controls.Add(choiceGroupBox);
            newGameBox.Controls.Add(label12);
            newGameBox.Controls.Add(label11);
            newGameBox.Controls.Add(label10);
            newGameBox.Controls.Add(label9);
            newGameBox.Controls.Add(label8);
            newGameBox.Controls.Add(label7);
            newGameBox.Controls.Add(label6);
            newGameBox.Controls.Add(label5);
            newGameBox.Controls.Add(pictureBox20);
            newGameBox.Controls.Add(pictureBox21);
            newGameBox.Controls.Add(pictureBox22);
            newGameBox.Controls.Add(pictureBox23);
            newGameBox.Controls.Add(pictureBox24);
            newGameBox.Controls.Add(pictureBox25);
            newGameBox.Controls.Add(pictureBox26);
            newGameBox.Controls.Add(pictureBox27);
            newGameBox.Controls.Add(pictureBox19);
            newGameBox.Controls.Add(pictureBox18);
            newGameBox.Controls.Add(pictureBox17);
            newGameBox.Controls.Add(pictureBox16);
            newGameBox.Controls.Add(pictureBox14);
            newGameBox.Controls.Add(pictureBox10);
            newGameBox.Controls.Add(pictureBox9);
            newGameBox.Controls.Add(pictureBox3);
            newGameBox.Controls.Add(hand2Bet2);
            newGameBox.Controls.Add(playerCard3);
            newGameBox.Controls.Add(dealerCard1);
            newGameBox.Controls.Add(hand1Bet2);
            newGameBox.Controls.Add(playerCard1);
            newGameBox.Controls.Add(dealerCountLabel);
            newGameBox.Controls.Add(hand2Bet1);
            newGameBox.Controls.Add(betLabel);
            newGameBox.Controls.Add(playerCountLabel);
            newGameBox.Controls.Add(hand1Bet1);
            newGameBox.Controls.Add(playerCard4);
            newGameBox.Controls.Add(label1);
            newGameBox.Controls.Add(pictureBox2);
            newGameBox.Controls.Add(label2);
            newGameBox.Controls.Add(pictureBox1);
            newGameBox.Controls.Add(walletLabel);
            newGameBox.Controls.Add(playerCard2);
            newGameBox.Controls.Add(pictureBox15);
            newGameBox.Controls.Add(dealerCard6);
            newGameBox.Controls.Add(pictureBox4);
            newGameBox.Controls.Add(pictureBox6);
            newGameBox.Controls.Add(pictureBox8);
            newGameBox.Controls.Add(dealerCard5);
            newGameBox.Controls.Add(pictureBox7);
            newGameBox.Controls.Add(pictureBox5);
            newGameBox.Controls.Add(dealerCard4);
            newGameBox.Controls.Add(dealerCard3);
            newGameBox.Controls.Add(dealerCard2);
            newGameBox.Location = new Point(27, 153);
            newGameBox.Name = "newGameBox";
            newGameBox.Size = new Size(935, 522);
            newGameBox.TabIndex = 51;
            newGameBox.TabStop = false;
            newGameBox.Visible = false;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(837, 390);
            label12.Name = "label12";
            label12.Size = new Size(34, 20);
            label12.TabIndex = 74;
            label12.Text = "Bet:";
            label12.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(747, 390);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 73;
            label11.Text = "Bet:";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(636, 390);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 72;
            label10.Text = "Bet:";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(544, 390);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 71;
            label9.Text = "Bet:";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(444, 390);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 70;
            label8.Text = "Bet:";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(355, 390);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 69;
            label7.Text = "Bet:";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 390);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 68;
            label6.Text = "Bet:";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 390);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 67;
            label5.Text = "Bet:";
            label5.Visible = false;
            // 
            // pictureBox20
            // 
            pictureBox20.Location = new Point(869, 413);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(41, 67);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.TabIndex = 66;
            pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.Location = new Point(822, 413);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(41, 67);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 65;
            pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            pictureBox22.Location = new Point(775, 413);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(41, 67);
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.TabIndex = 64;
            pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            pictureBox23.Location = new Point(728, 413);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(41, 67);
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox23.TabIndex = 63;
            pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            pictureBox24.Location = new Point(669, 413);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(41, 67);
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox24.TabIndex = 62;
            pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            pictureBox25.Location = new Point(622, 413);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(41, 67);
            pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox25.TabIndex = 61;
            pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            pictureBox26.Location = new Point(572, 413);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(41, 67);
            pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox26.TabIndex = 60;
            pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            pictureBox27.Location = new Point(525, 413);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(41, 67);
            pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox27.TabIndex = 59;
            pictureBox27.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.Location = new Point(473, 413);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(41, 67);
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.TabIndex = 58;
            pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Location = new Point(426, 413);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(41, 67);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.TabIndex = 57;
            pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.Location = new Point(379, 413);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(41, 67);
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.TabIndex = 56;
            pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(332, 413);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(41, 67);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 55;
            pictureBox16.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(273, 413);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(41, 67);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 54;
            pictureBox14.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(226, 413);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(41, 67);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 53;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(176, 413);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(41, 67);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 52;
            pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(129, 413);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard4).EndInit();
            newGameBox.ResumeLayout(false);
            newGameBox.PerformLayout();
            choiceGroupBox.ResumeLayout(false);
            choiceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox dealerCard2;
        private PictureBox dealerCard3;
        private PictureBox dealerCard4;
        private PictureBox dealerCard5;
        private PictureBox dealerCard6;
        private PictureBox pictureBox15;
        private PictureBox playerCard3;
        private PictureBox playerCard4;
        private Label betLabel;
        private Label hand1Bet1;
        private Label hand2Bet1;
        private Label hand1Bet2;
        private Label hand2Bet2;
        private GroupBox newGameBox;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox17;
        private PictureBox pictureBox16;
        private PictureBox pictureBox14;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox3;
        private GroupBox choiceGroupBox;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox enterBetTextbox;
    }
}