namespace WindowsFormsApp1 {
    partial class BiggerCard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelBet = new System.Windows.Forms.Label();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.buttonDrawYourCard = new System.Windows.Forms.Button();
            this.buttonDrawComputerCard = new System.Windows.Forms.Button();
            this.textBoxPlayerStatus = new System.Windows.Forms.TextBox();
            this.textBoxBigCardUsername = new System.Windows.Forms.TextBox();
            this.textBoxBigCardUserBalance = new System.Windows.Forms.TextBox();
            this.labelBigCardUsername = new System.Windows.Forms.Label();
            this.labelBigCardBalance = new System.Windows.Forms.Label();
            this.pictureBoxPlayersCard = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxComputersCard = new System.Windows.Forms.PictureBox();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cashOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayersCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputersCard)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Location = new System.Drawing.Point(235, 113);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(27, 16);
            this.labelBet.TabIndex = 0;
            this.labelBet.Text = "Bet";
            // 
            // textBoxBet
            // 
            this.textBoxBet.Location = new System.Drawing.Point(304, 113);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(100, 22);
            this.textBoxBet.TabIndex = 1;
            this.textBoxBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBet.TextChanged += new System.EventHandler(this.textBoxBet_TextChanged);
            // 
            // buttonDrawYourCard
            // 
            this.buttonDrawYourCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDrawYourCard.ForeColor = System.Drawing.Color.Lime;
            this.buttonDrawYourCard.Location = new System.Drawing.Point(150, 264);
            this.buttonDrawYourCard.Name = "buttonDrawYourCard";
            this.buttonDrawYourCard.Size = new System.Drawing.Size(142, 32);
            this.buttonDrawYourCard.TabIndex = 2;
            this.buttonDrawYourCard.Text = "Draw your card";
            this.buttonDrawYourCard.UseVisualStyleBackColor = false;
            this.buttonDrawYourCard.Click += new System.EventHandler(this.buttonDrawYourCard_Click);
            // 
            // buttonDrawComputerCard
            // 
            this.buttonDrawComputerCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDrawComputerCard.ForeColor = System.Drawing.Color.Lime;
            this.buttonDrawComputerCard.Location = new System.Drawing.Point(977, 264);
            this.buttonDrawComputerCard.Name = "buttonDrawComputerCard";
            this.buttonDrawComputerCard.Size = new System.Drawing.Size(151, 32);
            this.buttonDrawComputerCard.TabIndex = 3;
            this.buttonDrawComputerCard.Text = "Draw computers card";
            this.buttonDrawComputerCard.UseVisualStyleBackColor = false;
            this.buttonDrawComputerCard.Click += new System.EventHandler(this.buttonDrawComputerCard_Click);
            // 
            // textBoxPlayerStatus
            // 
            this.textBoxPlayerStatus.BackColor = System.Drawing.Color.Black;
            this.textBoxPlayerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerStatus.ForeColor = System.Drawing.Color.Red;
            this.textBoxPlayerStatus.Location = new System.Drawing.Point(535, 623);
            this.textBoxPlayerStatus.Name = "textBoxPlayerStatus";
            this.textBoxPlayerStatus.Size = new System.Drawing.Size(234, 45);
            this.textBoxPlayerStatus.TabIndex = 6;
            this.textBoxPlayerStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPlayerStatus.TextChanged += new System.EventHandler(this.textBoxPlayerStatus_TextChanged);
            // 
            // textBoxBigCardUsername
            // 
            this.textBoxBigCardUsername.Location = new System.Drawing.Point(304, 42);
            this.textBoxBigCardUsername.Name = "textBoxBigCardUsername";
            this.textBoxBigCardUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxBigCardUsername.TabIndex = 7;
            // 
            // textBoxBigCardUserBalance
            // 
            this.textBoxBigCardUserBalance.Location = new System.Drawing.Point(547, 42);
            this.textBoxBigCardUserBalance.Name = "textBoxBigCardUserBalance";
            this.textBoxBigCardUserBalance.Size = new System.Drawing.Size(100, 22);
            this.textBoxBigCardUserBalance.TabIndex = 8;
            this.textBoxBigCardUserBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelBigCardUsername
            // 
            this.labelBigCardUsername.AutoSize = true;
            this.labelBigCardUsername.Location = new System.Drawing.Point(206, 48);
            this.labelBigCardUsername.Name = "labelBigCardUsername";
            this.labelBigCardUsername.Size = new System.Drawing.Size(70, 16);
            this.labelBigCardUsername.TabIndex = 9;
            this.labelBigCardUsername.Text = "Username";
            // 
            // labelBigCardBalance
            // 
            this.labelBigCardBalance.AutoSize = true;
            this.labelBigCardBalance.Location = new System.Drawing.Point(452, 48);
            this.labelBigCardBalance.Name = "labelBigCardBalance";
            this.labelBigCardBalance.Size = new System.Drawing.Size(57, 16);
            this.labelBigCardBalance.TabIndex = 10;
            this.labelBigCardBalance.Text = "Balance";
            // 
            // pictureBoxPlayersCard
            // 
            this.pictureBoxPlayersCard.Location = new System.Drawing.Point(150, 344);
            this.pictureBoxPlayersCard.Name = "pictureBoxPlayersCard";
            this.pictureBoxPlayersCard.Size = new System.Drawing.Size(196, 228);
            this.pictureBoxPlayersCard.TabIndex = 12;
            this.pictureBoxPlayersCard.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.playing_cards_back_on_white_background_with_path_DFE2552;
            this.pictureBox1.Location = new System.Drawing.Point(506, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 240);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxComputersCard
            // 
            this.pictureBoxComputersCard.Location = new System.Drawing.Point(977, 344);
            this.pictureBoxComputersCard.Name = "pictureBoxComputersCard";
            this.pictureBoxComputersCard.Size = new System.Drawing.Size(198, 228);
            this.pictureBoxComputersCard.TabIndex = 13;
            this.pictureBoxComputersCard.TabStop = false;
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.playAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgainButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.playAgainButton.Location = new System.Drawing.Point(535, 448);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(234, 70);
            this.playAgainButton.TabIndex = 15;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = ".00 $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = ".00 $";
            // 
            // cashOutButton
            // 
            this.cashOutButton.BackColor = System.Drawing.Color.Black;
            this.cashOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashOutButton.ForeColor = System.Drawing.Color.Lime;
            this.cashOutButton.Location = new System.Drawing.Point(535, 538);
            this.cashOutButton.Name = "cashOutButton";
            this.cashOutButton.Size = new System.Drawing.Size(234, 66);
            this.cashOutButton.TabIndex = 20;
            this.cashOutButton.Text = "CASH OUT";
            this.cashOutButton.UseVisualStyleBackColor = false;
            this.cashOutButton.Click += new System.EventHandler(this.cashOutButtonClick);
            // 
            // BiggerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Controls.Add(this.cashOutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.pictureBoxComputersCard);
            this.Controls.Add(this.pictureBoxPlayersCard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelBigCardBalance);
            this.Controls.Add(this.labelBigCardUsername);
            this.Controls.Add(this.textBoxBigCardUserBalance);
            this.Controls.Add(this.textBoxBigCardUsername);
            this.Controls.Add(this.textBoxPlayerStatus);
            this.Controls.Add(this.buttonDrawComputerCard);
            this.Controls.Add(this.buttonDrawYourCard);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.labelBet);
            this.Name = "BiggerCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiggerCard";
            this.Load += new System.EventHandler(this.BiggerCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayersCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputersCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Button buttonDrawYourCard;
        private System.Windows.Forms.Button buttonDrawComputerCard;
        private System.Windows.Forms.TextBox textBoxPlayerStatus;
        private System.Windows.Forms.TextBox textBoxBigCardUsername;
        private System.Windows.Forms.TextBox textBoxBigCardUserBalance;
        private System.Windows.Forms.Label labelBigCardUsername;
        private System.Windows.Forms.Label labelBigCardBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxPlayersCard;
        private System.Windows.Forms.PictureBox pictureBoxComputersCard;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cashOutButton;
    }
}