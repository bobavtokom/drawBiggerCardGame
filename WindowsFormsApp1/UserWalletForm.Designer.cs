﻿namespace WindowsFormsApp1 {
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
            this.dataGridViewUserWallet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserWallet_CellContentClick);
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
            // UserWalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.dataGridViewUserWallet);
            this.Name = "UserWalletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserWalletForm";
            this.Load += new System.EventHandler(this.UserWalletForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserWallet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCardPayingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTimeOfPayment;
        private System.Windows.Forms.Button buttonPlay;
    }
}