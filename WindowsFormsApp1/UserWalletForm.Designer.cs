namespace WindowsFormsApp1 {
    partial class UserWalletForm {
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
            this.dataGridViewUserWallet = new System.Windows.Forms.DataGridView();
            this.dgvCardPayingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTimeOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.textBoxUserNameP = new System.Windows.Forms.TextBox();
            this.textBoxUserBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserWallet
            // 
            this.dataGridViewUserWallet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUserWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserWallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCardPayingId,
            this.dgvCardName,
            this.dgvCardNumber,
            this.dgvTimeOfPayment});
            this.dataGridViewUserWallet.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUserWallet.Location = new System.Drawing.Point(176, 213);
            this.dataGridViewUserWallet.Name = "dataGridViewUserWallet";
            this.dataGridViewUserWallet.ReadOnly = true;
            this.dataGridViewUserWallet.RowHeadersWidth = 51;
            this.dataGridViewUserWallet.RowTemplate.Height = 24;
            this.dataGridViewUserWallet.RowTemplate.ReadOnly = true;
            this.dataGridViewUserWallet.Size = new System.Drawing.Size(591, 119);
            this.dataGridViewUserWallet.TabIndex = 0;
            this.dataGridViewUserWallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserWalletForm_KeyDown);
            // 
            // dgvCardPayingId
            // 
            this.dgvCardPayingId.DataPropertyName = "CardPayingId";
            this.dgvCardPayingId.HeaderText = "CardPayingId";
            this.dgvCardPayingId.MinimumWidth = 6;
            this.dgvCardPayingId.Name = "dgvCardPayingId";
            this.dgvCardPayingId.ReadOnly = true;
            this.dgvCardPayingId.Visible = false;
            this.dgvCardPayingId.Width = 125;
            // 
            // dgvCardName
            // 
            this.dgvCardName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCardName.DataPropertyName = "CardName";
            this.dgvCardName.HeaderText = "Card name";
            this.dgvCardName.MinimumWidth = 6;
            this.dgvCardName.Name = "dgvCardName";
            this.dgvCardName.ReadOnly = true;
            // 
            // dgvCardNumber
            // 
            this.dgvCardNumber.DataPropertyName = "CardNumber";
            this.dgvCardNumber.HeaderText = "Card number";
            this.dgvCardNumber.MinimumWidth = 6;
            this.dgvCardNumber.Name = "dgvCardNumber";
            this.dgvCardNumber.ReadOnly = true;
            this.dgvCardNumber.Width = 125;
            // 
            // dgvTimeOfPayment
            // 
            this.dgvTimeOfPayment.DataPropertyName = "TimeOfPayment";
            this.dgvTimeOfPayment.HeaderText = "Time of payment";
            this.dgvTimeOfPayment.MinimumWidth = 6;
            this.dgvTimeOfPayment.Name = "dgvTimeOfPayment";
            this.dgvTimeOfPayment.ReadOnly = true;
            this.dgvTimeOfPayment.Width = 125;
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.Black;
            this.ButtonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlay.ForeColor = System.Drawing.Color.Chartreuse;
            this.ButtonPlay.Location = new System.Drawing.Point(349, 383);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(239, 48);
            this.ButtonPlay.TabIndex = 1;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // textBoxUserNameP
            // 
            this.textBoxUserNameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserNameP.Location = new System.Drawing.Point(338, 68);
            this.textBoxUserNameP.Name = "textBoxUserNameP";
            this.textBoxUserNameP.Size = new System.Drawing.Size(166, 30);
            this.textBoxUserNameP.TabIndex = 2;
            // 
            // textBoxUserBalance
            // 
            this.textBoxUserBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserBalance.Location = new System.Drawing.Point(338, 118);
            this.textBoxUserBalance.Name = "textBoxUserBalance";
            this.textBoxUserBalance.Size = new System.Drawing.Size(88, 30);
            this.textBoxUserBalance.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "balance";
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Black;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.Red;
            this.QuitButton.Location = new System.Drawing.Point(349, 476);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(239, 47);
            this.QuitButton.TabIndex = 6;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ".00 $";
            // 
            // UserWalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 760);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserBalance);
            this.Controls.Add(this.textBoxUserNameP);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.dataGridViewUserWallet);
            this.Name = "UserWalletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWalletForm";
            this.Load += new System.EventHandler(this.UserWalletForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserWallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCardPayingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTimeOfPayment;
        private System.Windows.Forms.TextBox textBoxUserNameP;
        private System.Windows.Forms.TextBox textBoxUserBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button QuitButton;
        public System.Windows.Forms.Button ButtonPlay;
    }
}