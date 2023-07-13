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
        public LoginPage() {
            InitializeComponent();
        }
        public void Clear() {
            TextBoxUsername.Text = TextBoxPassword.Text = "";
        }
        private async void buttonRegister_Click(object sender, EventArgs e) {
            var userNewForm = new UserNewForm();
            await Task.Run(() => userNewForm.ShowDialog());
            this.Close();
        }

        private async void buttonLogin_Click(object sender, EventArgs e) {

            using (EFDbNewUserEntities1 context = new EFDbNewUserEntities1()) {
                string username = TextBoxUsername.Text.Trim();
                string password = TextBoxPassword.Text.Trim();

                if (!string.IsNullOrWhiteSpace(username) || !string.IsNullOrWhiteSpace(password)) {
                    var loginSuccess = await Task.Run(() =>
                        context.UserNews.Any(l => l.UserNewName == username && l.UserNewPassword == password));

                    if (loginSuccess) {
                        PaymentForm paymentForm = new PaymentForm();
                        paymentForm.ShowDialog();
                        this.Close();
                    } else {
                        MessageBox.Show("User not found", "Login failed", MessageBoxButtons.OK);
                        Clear();
                    }
                }
            }
        }

    }
}
