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
        public int UserBalance { get; set; }
        public UserWalletForm() {
            InitializeComponent();
        }
        private void UserWalletForm_Load(object sender, EventArgs e) {

            var context = new EFDbCardPayingEntity();
            var lastRecord = context.CardPayings.OrderByDescending(x => x.CardPayingId).FirstOrDefault();
            var bindingList = new BindingList<CardPaying>(new[] { lastRecord });
            var source = new BindingSource(bindingList, null);
            dataGridViewUserWallet.DataSource = source;
            var userWalletForm = new UserWalletForm();
            var dbUserNew = new EFDbNewUserEntities1();
            UserName = dbUserNew.UserNews.OrderByDescending(c => c.UserNewId).Select(c => c.UserNewName).FirstOrDefault();
            textBoxUserNameP.Text = UserName;
            textBoxUserNameP.ReadOnly = true;
            var UserBalance = dbUserNew.UserNews.OrderByDescending(c => c.UserNewId).Select(c => c.UserNewBalance).FirstOrDefault();
            textBoxUserBalance.Text = UserBalance.ToString();
            textBoxUserBalance.ReadOnly = true;
        }

        private void buttonPlay_Click(object sender, EventArgs e) {
            var biggerCard = new BiggerCard(textBoxUserNameP.Text, float.Parse(textBoxUserBalance.Text.ToString()));
            biggerCard.Show();
        }
    }
}
