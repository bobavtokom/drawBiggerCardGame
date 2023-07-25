using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1 {
    public partial class UserWalletForm : Form {
        public string UserName { get; set; }
        private bool _cashoutSwitch = false;
        public bool CashoutSwitch { 
            get { return _cashoutSwitch; }
            set { _cashoutSwitch = value; }
         }
        public int? UserBalance { get; set; }
        public string LoggedUsername { get; set; }
        public string LoggedPassword { get; set; }

        EFDbNewUserEntities1 dbUserNew = new EFDbNewUserEntities1();
        public UserWalletForm() {
            InitializeComponent();
           QuitButton.Visible = false;
        }
        public UserWalletForm(string username, string password) {
            InitializeComponent();
            LoggedUsername = username;
            LoggedPassword = password;
            this.KeyDown += UserWalletForm_KeyDown;
            QuitButton.Visible = false;
            ButtonPlay.Focus();
        }
        void IsLoggedIn() {
            if (!string.IsNullOrWhiteSpace(LoggedUsername) && !string.IsNullOrWhiteSpace(LoggedPassword)){
                textBoxUserNameP.Text = LoggedUsername;
                UserBalance = dbUserNew.UserNews.Where(u => u.UserNewName == LoggedUsername).Select(u => u.UserNewBalance).FirstOrDefault();
                
            } else {
                textBoxUserNameP.Text = UserName;
            }
        }
        private void UserWalletForm_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {

                var biggerCard = new BiggerCard(textBoxUserNameP.Text, float.Parse(textBoxUserBalance.Text.ToString()));
                biggerCard.Show();

                QuitButton.Visible = true;
                ButtonPlay.Visible = false;
                e.SuppressKeyPress = true;
            }
        }


        private void UserWalletForm_Load(object sender, EventArgs e) {
            ButtonPlay.Focus();
            var context = new EFDbCardPayingEntity();
            var lastRecord = context.CardPayings.OrderByDescending(x => x.CardPayingId).FirstOrDefault();
            if(CashoutSwitch == true) lastRecord.TimeOfPayment = DateTime.Now;
            var bindingList = new BindingList<CardPaying>(new[] { lastRecord });
            var source = new BindingSource(bindingList, null);
            dataGridViewUserWallet.DataSource = source;
            var userWalletForm = new UserWalletForm();
            UserName = dbUserNew.UserNews.OrderByDescending(c => c.UserNewId).Select(c => c.UserNewName).FirstOrDefault();
            IsLoggedIn();
            textBoxUserNameP.ReadOnly = true;
            UserBalance = dbUserNew.UserNews.OrderByDescending(c => c.UserNewId).Select(c => c.UserNewBalance).FirstOrDefault();
            textBoxUserBalance.Text = UserBalance.ToString();
            textBoxUserBalance.ReadOnly = true;
        }

        private void ButtonPlay_Click(object sender, EventArgs e) {
            var biggerCard = new BiggerCard(textBoxUserNameP.Text, float.Parse(textBoxUserBalance.Text.ToString()));
            biggerCard.Show();
        }

        private void QuitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
