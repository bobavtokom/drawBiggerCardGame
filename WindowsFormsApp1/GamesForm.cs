using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class GamesForm : Form {
        public string UserName { get; set; }
        public int UserBalance { get; set; }
        public GamesForm() {
            InitializeComponent();
        }
       

        private void GamesForm_Load(object sender, EventArgs e) {
            var userWalletForm = new UserWalletForm(); 
            var dbUserNew = new EFDbNewUserEntities1();
            UserName = dbUserNew.UserNews.OrderByDescending(c => c.UserNewId).Select(c => c.UserNewName).FirstOrDefault();
            textBoxUserNameP.Text = UserName;
            var UserBalance = dbUserNew.UserNews.OrderByDescending(c => c.UserNewId).Select(c => c.UserNewBalance).FirstOrDefault();
            textBoxUserBalance.Text = UserBalance.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void buttonPlayGame_Click(object sender, EventArgs e) {
            
                    
                        if(checkBoxBiggerCard.Checked) {

                            var biggerCard = new BiggerCard(textBoxUserNameP.Text, textBoxUserBalance.Text.ToString());
                            biggerCard.Show();
                    }
        }
    }
}
