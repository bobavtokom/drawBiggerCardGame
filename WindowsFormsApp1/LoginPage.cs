using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class LoginPage : Form , IClearForm {
        public string Username { get; set; }
        
        public LoginPage() {
            InitializeComponent();
            TextBoxUsername.KeyDown += textBoxUsername_KeyDown;
            TextBoxPassword.KeyDown += textBoxPassword_KeyDown;
        }
        public void Clear() {
            TextBoxUsername.Text = TextBoxPassword.Text = "";
        }
        private async void buttonRegister_Click(object sender, EventArgs e) {
            var userNewForm = new UserNewForm();
            await Task.Run(() => userNewForm.ShowDialog());
            this.Close();
        }
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {

                Username = TextBoxUsername.Text.Trim();

                if (!string.IsNullOrWhiteSpace(Username)) {
                    TextBoxPassword.Focus();
                    e.SuppressKeyPress = true; 
                }
            }
        } 
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {

                string password = TextBoxPassword.Text.Trim();

                if (!string.IsNullOrWhiteSpace(password)) {
                     buttonLogin.Focus();
                    e.SuppressKeyPress = true; 
                }
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e) {

            using (EFDbNewUserEntities1 context = new EFDbNewUserEntities1()) {
                string username = TextBoxUsername.Text.Trim();
                string password = TextBoxPassword.Text.Trim();

                if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password)) {
                    var loginSuccess = await Task.Run(() =>
                        context.UserNews.Any(l => l.UserNewName == username && l.UserNewPassword == password));

                    if (loginSuccess) {
                        var userWallet = new UserWalletForm(username, password);
                        userWallet.ShowDialog();
                        this.Close();
                    } else {
                        MessageBox.Show("User not found", "Login failed", MessageBoxButtons.OK);
                        Clear();
                    }
                } else {
                    MessageBox.Show("Please enter username and password", "Login failed", MessageBoxButtons.OK);
                }
            }
        }

    }
}
