﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class UserNewForm : Form, IClearForm {

        UserNew userNew = new UserNew();

        public UserNewForm() {
            InitializeComponent();
            buttonPay.Enabled = false;  
        }
        private void buttonCancel_Click(object sender, EventArgs e) {
                
             Clear();
        }
        public void Clear() {
            textBoxUserName.Text = textBoxUserBalance.Text = TextBoxPassword.Text = "";
            buttonSave.Text = "Save";
            buttonDelete.Enabled = false;
            userNew.UserNewId = 0;
        }

        private async void UserNewForm_Load(object sender, EventArgs e) {
            Clear();
            this.ActiveControl = textBoxUserName;
            await LoadDataAsync();
        }

        private async Task LoadDataAsync() {
            try {
                using (var context = new EFDbNewUserEntities1()) {

                    var lastRecord = await context.UserNews.OrderByDescending(x => x.UserNewId).FirstOrDefaultAsync();
                    var bindingList = new BindingList<UserNew>(new[] { lastRecord });
                    var source = new BindingSource(bindingList, null);
                    dataGridViewNewUser.DataSource = source;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e) {
            try {
                string userName = textBoxUserName.Text.Trim();
                string userBalanceText = textBoxUserBalance.Text.Trim();
                string password = TextBoxPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userBalanceText) || string.IsNullOrWhiteSpace(password)) {
                    MessageBox.Show("Please fill out the fields.");
                    return;
                }

                if (!int.TryParse(userBalanceText, out int userBalance)) {
                    MessageBox.Show("Please enter a valid integer for the balance.");
                    return;
                }
                userNew.UserNewName = userName;
                userNew.UserNewBalance = userBalance;
                userNew.UserNewPassword = password;

                using (EFDbNewUserEntities1 db = new EFDbNewUserEntities1()) {
                    if (userNew.UserNewId == 0) {
                        db.UserNews.Add(userNew);
                        buttonPay.Enabled = true;
                    } else {
                        db.Entry(userNew).State = System.Data.Entity.EntityState.Modified;
                        buttonPay.Enabled = true;
                    }

                    await db.SaveChangesAsync();
                }

                Clear();
                await LoadDataAsync();
                MessageBox.Show("Successfully submitted");
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void dataGridViewNewUser_DoubleClick(object sender, EventArgs e) {

            if(dataGridViewNewUser.CurrentRow.Index != -1) {
                userNew.UserNewId = Convert.ToInt32(dataGridViewNewUser.CurrentRow.Cells["UserNewId"].Value);
                using(EFDbNewUserEntities1 db = new EFDbNewUserEntities1()) {
                    userNew = db.UserNews.Where(x => x.UserNewId == userNew.UserNewId).FirstOrDefault();
                    textBoxUserName.Text = userNew.UserNewName;
                    textBoxUserBalance.Text = userNew.UserNewBalance.ToString();
                    TextBoxPassword.Text = userNew.UserNewPassword;
                }
                buttonSave.Text = "Update";
                buttonDelete.Enabled = true;
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e) {

            if(MessageBox.Show("Are you sure to delete this record?","Message",MessageBoxButtons.YesNo)== DialogResult.Yes) {
                using(EFDbNewUserEntities1 db = new EFDbNewUserEntities1()) {
                    var entry = db.Entry(userNew);
                    if(entry.State == System.Data.Entity.EntityState.Detached) {
                        db.UserNews.Attach(userNew);
                        db.UserNews.Remove(userNew);
                        db.SaveChanges();
                       await LoadDataAsync();
                        Clear();
                        MessageBox.Show("Successfully removed record");
                    }
                }
            }
        }

        private void buttonPay_Click(object sender, EventArgs e) {

            var paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
            this.Close();
        }

        private void textBoxUserBalance_TextChanged(object sender, EventArgs e) {
            if(userNew.UserNewId != 0) {
                textBoxUserBalance.ReadOnly = true;
                textBoxUserName.ReadOnly = true;
            } else {
                if(!float.TryParse(textBoxUserBalance.Text, out var balance)) {
                    MessageBox.Show("Please enter a valid number", "ATTENTION", MessageBoxButtons.OK);
                }
            }
        }
    }
}
