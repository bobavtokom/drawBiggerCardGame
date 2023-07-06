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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.textBoxUserNameP = new System.Windows.Forms.TextBox();
            this.textBoxUserBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridViewUserWallet.Location = new System.Drawing.Point(102, 212);
            this.dataGridViewUserWallet.Name = "dataGridViewUserWallet";
            this.dataGridViewUserWallet.RowHeadersWidth = 51;
            this.dataGridViewUserWallet.RowTemplate.Height = 24;
            this.dataGridViewUserWallet.Size = new System.Drawing.Size(591, 119);
            this.dataGridViewUserWallet.TabIndex = 0;
            // 
            // dgvCardPayingId
            // 
            this.dgvCardPayingId.DataPropertyName = "CardPayingId";
            this.dgvCardPayingId.HeaderText = "CardPayingId";
            this.dgvCardPayingId.MinimumWidth = 6;
            this.dgvCardPayingId.Name = "dgvCardPayingId";
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
            // 
            // dgvCardNumber
            // 
            this.dgvCardNumber.DataPropertyName = "CardNumber";
            this.dgvCardNumber.HeaderText = "Card number";
            this.dgvCardNumber.MinimumWidth = 6;
            this.dgvCardNumber.Name = "dgvCardNumber";
            this.dgvCardNumber.Width = 125;
            // 
            // dgvTimeOfPayment
            // 
            this.dgvTimeOfPayment.DataPropertyName = "TimeOfPayment";
            this.dgvTimeOfPayment.HeaderText = "Time of payment";
            this.dgvTimeOfPayment.MinimumWidth = 6;
            this.dgvTimeOfPayment.Name = "dgvTimeOfPayment";
            this.dgvTimeOfPayment.Width = 125;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPlay.Location = new System.Drawing.Point(282, 384);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(239, 48);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // textBoxUserNameP
            // 
            this.textBoxUserNameP.Location = new System.Drawing.Point(338, 61);
            this.textBoxUserNameP.Name = "textBoxUserNameP";
            this.textBoxUserNameP.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserNameP.TabIndex = 2;
            // 
            // textBoxUserBalance
            // 
            this.textBoxUserBalance.Location = new System.Drawing.Point(338, 105);
            this.textBoxUserBalance.Name = "textBoxUserBalance";
            this.textBoxUserBalance.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserBalance.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "balance";
            // 
            // UserWalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 760);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserBalance);
            this.Controls.Add(this.textBoxUserNameP);
            this.Controls.Add(this.buttonPlay);
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
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox textBoxUserNameP;
        private System.Windows.Forms.TextBox textBoxUserBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}