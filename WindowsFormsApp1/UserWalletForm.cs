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

namespace WindowsFormsApp1 {
    public partial class UserWalletForm : Form {
        
        public UserWalletForm() {
            InitializeComponent();
        }
        private void UserWalletForm_Load(object sender, EventArgs e) {
            var context = new EFDbCardPayingEntity();
            var lastRecord = context.CardPayings.OrderByDescending(x => x.CardPayingId).FirstOrDefault();
            var bindingList = new BindingList<CardPaying>(new[] { lastRecord });
            var source = new BindingSource(bindingList, null);
            dataGridViewUserWallet.DataSource = source;
        }

        private void dataGridViewUserWallet_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void buttonPlay_Click(object sender, EventArgs e) {
            var gamesForm = new GamesForm();
            gamesForm.ShowDialog();
          

        }
    }
}
