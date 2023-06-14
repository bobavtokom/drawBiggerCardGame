namespace WindowsFormsApp1 {
    partial class GamesForm {
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserBalance = new System.Windows.Forms.Label();
            this.textBoxUserBalance = new System.Windows.Forms.TextBox();
            this.textBoxUserNameP = new System.Windows.Forms.TextBox();
            this.buttonPlayGame = new System.Windows.Forms.Button();
            this.checkBoxBiggerCard = new System.Windows.Forms.CheckBox();
            this.checkBoxMatrix = new System.Windows.Forms.CheckBox();
            this.checkBoxPyramid = new System.Windows.Forms.CheckBox();
            this.pictureBoxMatrix = new System.Windows.Forms.PictureBox();
            this.pictureBoxPyramid = new System.Windows.Forms.PictureBox();
            this.pictureBoxBiggerGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPyramid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBiggerGame)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(289, 73);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 16);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelUserBalance
            // 
            this.labelUserBalance.AutoSize = true;
            this.labelUserBalance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelUserBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUserBalance.Location = new System.Drawing.Point(289, 106);
            this.labelUserBalance.Name = "labelUserBalance";
            this.labelUserBalance.Size = new System.Drawing.Size(57, 16);
            this.labelUserBalance.TabIndex = 1;
            this.labelUserBalance.Text = "Balance";
            // 
            // textBoxUserBalance
            // 
            this.textBoxUserBalance.BackColor = System.Drawing.Color.Cyan;
            this.textBoxUserBalance.Location = new System.Drawing.Point(413, 101);
            this.textBoxUserBalance.Name = "textBoxUserBalance";
            this.textBoxUserBalance.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserBalance.TabIndex = 3;
            // 
            // textBoxUserNameP
            // 
            this.textBoxUserNameP.Location = new System.Drawing.Point(413, 73);
            this.textBoxUserNameP.Name = "textBoxUserNameP";
            this.textBoxUserNameP.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserNameP.TabIndex = 4;
            // 
            // buttonPlayGame
            // 
            this.buttonPlayGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPlayGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlayGame.Location = new System.Drawing.Point(338, 578);
            this.buttonPlayGame.Name = "buttonPlayGame";
            this.buttonPlayGame.Size = new System.Drawing.Size(357, 79);
            this.buttonPlayGame.TabIndex = 6;
            this.buttonPlayGame.Text = "Play";
            this.buttonPlayGame.UseVisualStyleBackColor = false;
            this.buttonPlayGame.Click += new System.EventHandler(this.buttonPlayGame_Click);
            // 
            // checkBoxBiggerCard
            // 
            this.checkBoxBiggerCard.AutoSize = true;
            this.checkBoxBiggerCard.Location = new System.Drawing.Point(752, 181);
            this.checkBoxBiggerCard.Name = "checkBoxBiggerCard";
            this.checkBoxBiggerCard.Size = new System.Drawing.Size(98, 20);
            this.checkBoxBiggerCard.TabIndex = 7;
            this.checkBoxBiggerCard.Text = "BiggerCard";
            this.checkBoxBiggerCard.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatrix
            // 
            this.checkBoxMatrix.AutoSize = true;
            this.checkBoxMatrix.Location = new System.Drawing.Point(463, 181);
            this.checkBoxMatrix.Name = "checkBoxMatrix";
            this.checkBoxMatrix.Size = new System.Drawing.Size(64, 20);
            this.checkBoxMatrix.TabIndex = 8;
            this.checkBoxMatrix.Text = "Matrix";
            this.checkBoxMatrix.UseVisualStyleBackColor = true;
            // 
            // checkBoxPyramid
            // 
            this.checkBoxPyramid.AutoSize = true;
            this.checkBoxPyramid.Location = new System.Drawing.Point(176, 181);
            this.checkBoxPyramid.Name = "checkBoxPyramid";
            this.checkBoxPyramid.Size = new System.Drawing.Size(79, 20);
            this.checkBoxPyramid.TabIndex = 9;
            this.checkBoxPyramid.Text = "Pyramid";
            this.checkBoxPyramid.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMatrix
            // 
            this.pictureBoxMatrix.Image = global::WindowsFormsApp1.Properties.Resources.locator;
            this.pictureBoxMatrix.Location = new System.Drawing.Point(429, 317);
            this.pictureBoxMatrix.Name = "pictureBoxMatrix";
            this.pictureBoxMatrix.Size = new System.Drawing.Size(197, 210);
            this.pictureBoxMatrix.TabIndex = 11;
            this.pictureBoxMatrix.TabStop = false;
            // 
            // pictureBoxPyramid
            // 
            this.pictureBoxPyramid.Image = global::WindowsFormsApp1.Properties.Resources._218764;
            this.pictureBoxPyramid.Location = new System.Drawing.Point(-84, 207);
            this.pictureBoxPyramid.Name = "pictureBoxPyramid";
            this.pictureBoxPyramid.Size = new System.Drawing.Size(419, 298);
            this.pictureBoxPyramid.TabIndex = 10;
            this.pictureBoxPyramid.TabStop = false;
            // 
            // pictureBoxBiggerGame
            // 
            this.pictureBoxBiggerGame.Image = global::WindowsFormsApp1.Properties.Resources.external_card_games_edutainment_flaticons_lineal_color_flat_icons_2;
            this.pictureBoxBiggerGame.Location = new System.Drawing.Point(678, 254);
            this.pictureBoxBiggerGame.Name = "pictureBoxBiggerGame";
            this.pictureBoxBiggerGame.Size = new System.Drawing.Size(259, 273);
            this.pictureBoxBiggerGame.TabIndex = 5;
            this.pictureBoxBiggerGame.TabStop = false;
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(977, 760);
            this.Controls.Add(this.pictureBoxMatrix);
            this.Controls.Add(this.pictureBoxPyramid);
            this.Controls.Add(this.checkBoxPyramid);
            this.Controls.Add(this.checkBoxMatrix);
            this.Controls.Add(this.checkBoxBiggerCard);
            this.Controls.Add(this.buttonPlayGame);
            this.Controls.Add(this.pictureBoxBiggerGame);
            this.Controls.Add(this.textBoxUserNameP);
            this.Controls.Add(this.textBoxUserBalance);
            this.Controls.Add(this.labelUserBalance);
            this.Controls.Add(this.labelUsername);
            this.Name = "GamesForm";
            this.Text = "GamesForm";
            this.Load += new System.EventHandler(this.GamesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPyramid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBiggerGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserBalance;
        private System.Windows.Forms.TextBox textBoxUserBalance;
        private System.Windows.Forms.TextBox textBoxUserNameP;
        private System.Windows.Forms.PictureBox pictureBoxBiggerGame;
        private System.Windows.Forms.Button buttonPlayGame;
        private System.Windows.Forms.CheckBox checkBoxBiggerCard;
        private System.Windows.Forms.CheckBox checkBoxMatrix;
        private System.Windows.Forms.CheckBox checkBoxPyramid;
        private System.Windows.Forms.PictureBox pictureBoxPyramid;
        private System.Windows.Forms.PictureBox pictureBoxMatrix;
    }
}