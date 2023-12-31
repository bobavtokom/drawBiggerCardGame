﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class PaymentForm : Form {
        public PaymentForm() {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            cardNumberBox3.MaxLength = 4;
            if (cardNumberBox3.Text.Length == 4) cardNumberBox4.Focus();
        }

        private void buttonPay_Click(object sender, EventArgs e) {

            if (string.IsNullOrWhiteSpace(textBoxCardName.Text) 
                || string.IsNullOrWhiteSpace(cardNumberbox1.Text) 
                || string.IsNullOrWhiteSpace(cardNumberBox2.Text)
                || string.IsNullOrWhiteSpace(cardNumberBox3.Text)
                || string.IsNullOrWhiteSpace(cardNumberBox4.Text)) 
            {
                MessageBox.Show("All fields are required", "Fill blank fields", MessageBoxButtons.OK);
            } else {

            var userNewForm = new UserNewForm();
            var cardPaying = new EFDbCardPayingEntity();
            var cardPayment = new CardPaying() {
                CardName = textBoxCardName.Text.Trim(),
                CardNumber = cardNumberbox1.Text.Trim() 
                + cardNumberBox2.Text.Trim()
                + cardNumberBox3.Text.Trim()
                + cardNumberBox4.Text.Trim(),
                TimeOfPayment = expiredDate.Value,
            };
            MessageBox.Show("Payment success");
            cardPaying.CardPayings.Add(cardPayment);
            cardPaying.SaveChanges();
            var userWallet = new UserWalletForm();
            userWallet.ShowDialog();
            this.Close();
            }
        }

        private void cardNumberbox1_TextChanged(object sender, EventArgs e) {

            cardNumberbox1.MaxLength = 4;
            if (cardNumberbox1.Text.Length == 4)  cardNumberBox2.Focus();
        }

        private void cardNumberBox2_TextChanged(object sender, EventArgs e) {

            cardNumberBox2.MaxLength = 4;
            if (cardNumberBox2.Text.Length == 4) cardNumberBox3.Focus();
        }

        private void cardNumberBox4_TextChanged(object sender, EventArgs e) {

            cardNumberBox4.MaxLength = 4;
        }
    }
}
