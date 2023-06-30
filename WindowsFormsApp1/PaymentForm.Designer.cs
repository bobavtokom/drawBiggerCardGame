namespace WindowsFormsApp1 {
    partial class PaymentForm {
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
            this.textBoxCardName = new System.Windows.Forms.TextBox();
            this.cardNumberbox1 = new System.Windows.Forms.TextBox();
            this.cardNumberBox2 = new System.Windows.Forms.TextBox();
            this.cardNumberBox3 = new System.Windows.Forms.TextBox();
            this.cardNumberBox4 = new System.Windows.Forms.TextBox();
            this.expiredDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardMaster = new System.Windows.Forms.PictureBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.cardName = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.Label();
            this.expireDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCardName
            // 
            this.textBoxCardName.Location = new System.Drawing.Point(465, 73);
            this.textBoxCardName.Name = "textBoxCardName";
            this.textBoxCardName.Size = new System.Drawing.Size(217, 22);
            this.textBoxCardName.TabIndex = 1;
            // 
            // cardNumberbox1
            // 
            this.cardNumberbox1.Location = new System.Drawing.Point(465, 169);
            this.cardNumberbox1.Name = "cardNumberbox1";
            this.cardNumberbox1.Size = new System.Drawing.Size(50, 22);
            this.cardNumberbox1.TabIndex = 2;
            this.cardNumberbox1.TextChanged += new System.EventHandler(this.cardNumberbox1_TextChanged);
            // 
            // cardNumberBox2
            // 
            this.cardNumberBox2.Location = new System.Drawing.Point(521, 169);
            this.cardNumberBox2.Name = "cardNumberBox2";
            this.cardNumberBox2.Size = new System.Drawing.Size(50, 22);
            this.cardNumberBox2.TabIndex = 2;
            this.cardNumberBox2.TextChanged += new System.EventHandler(this.cardNumberBox2_TextChanged);
            // 
            // cardNumberBox3
            // 
            this.cardNumberBox3.Location = new System.Drawing.Point(577, 169);
            this.cardNumberBox3.Name = "cardNumberBox3";
            this.cardNumberBox3.Size = new System.Drawing.Size(50, 22);
            this.cardNumberBox3.TabIndex = 2;
            this.cardNumberBox3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cardNumberBox4
            // 
            this.cardNumberBox4.Location = new System.Drawing.Point(633, 169);
            this.cardNumberBox4.Name = "cardNumberBox4";
            this.cardNumberBox4.Size = new System.Drawing.Size(50, 22);
            this.cardNumberBox4.TabIndex = 2;
            this.cardNumberBox4.TextChanged += new System.EventHandler(this.cardNumberBox4_TextChanged);
            // 
            // expiredDate
            // 
            this.expiredDate.Location = new System.Drawing.Point(465, 276);
            this.expiredDate.Name = "expiredDate";
            this.expiredDate.Size = new System.Drawing.Size(233, 22);
            this.expiredDate.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cardMaster);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 760);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Credit_Card_Payment_Maestro_256;
            this.pictureBox2.Location = new System.Drawing.Point(38, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 223);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Double_J_Design_Ravenna_3d_Credit_Card_256;
            this.pictureBox1.Location = new System.Drawing.Point(38, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 239);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cardMaster
            // 
            this.cardMaster.Image = global::WindowsFormsApp1.Properties.Resources.Designbolts_Credit_Card_Payment_Master_Card_Blue_256;
            this.cardMaster.Location = new System.Drawing.Point(38, 185);
            this.cardMaster.Name = "cardMaster";
            this.cardMaster.Size = new System.Drawing.Size(258, 236);
            this.cardMaster.TabIndex = 1;
            this.cardMaster.TabStop = false;
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonPay.Location = new System.Drawing.Point(465, 466);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(218, 37);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // cardName
            // 
            this.cardName.AutoSize = true;
            this.cardName.Location = new System.Drawing.Point(519, 45);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(76, 16);
            this.cardName.TabIndex = 7;
            this.cardName.Text = "Card Name";
            // 
            // cardNumber
            // 
            this.cardNumber.AutoSize = true;
            this.cardNumber.Location = new System.Drawing.Point(517, 137);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(87, 16);
            this.cardNumber.TabIndex = 7;
            this.cardNumber.Text = "Card Number";
            // 
            // expireDate
            // 
            this.expireDate.AutoSize = true;
            this.expireDate.Location = new System.Drawing.Point(518, 241);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(77, 16);
            this.expireDate.TabIndex = 7;
            this.expireDate.Text = "Expire Date";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 760);
            this.Controls.Add(this.expireDate);
            this.Controls.Add(this.cardNumber);
            this.Controls.Add(this.cardName);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.expiredDate);
            this.Controls.Add(this.cardNumberBox4);
            this.Controls.Add(this.cardNumberBox3);
            this.Controls.Add(this.cardNumberBox2);
            this.Controls.Add(this.cardNumberbox1);
            this.Controls.Add(this.textBoxCardName);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCardName;
        private System.Windows.Forms.TextBox cardNumberbox1;
        private System.Windows.Forms.TextBox cardNumberBox2;
        private System.Windows.Forms.TextBox cardNumberBox3;
        private System.Windows.Forms.TextBox cardNumberBox4;
        private System.Windows.Forms.DateTimePicker expiredDate;
        private System.Windows.Forms.PictureBox cardMaster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label cardName;
        private System.Windows.Forms.Label cardNumber;
        private System.Windows.Forms.Label expireDate;
    }
}