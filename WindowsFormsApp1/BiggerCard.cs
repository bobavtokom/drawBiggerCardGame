using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1 {
    public partial class BiggerCard : Form {
        public int Bet => int.Parse(textBoxBet.Text); 
        public static int min = 1;
        public static int max = 14;
        public static Random deckOfCards = new Random();
        public static int yourCard = deckOfCards.Next(min, max);
        public static int compCard = deckOfCards.Next(min, max);

        
        public BiggerCard(string tbUsername,string userBalance ) {
            InitializeComponent();
           textBoxBigCardUsername.Text = tbUsername;
            textBoxBigCardUserBalance.Text = userBalance.ToString();
            pictureBoxPlayersCard.Visible = false;
            pictureBoxComputersCard.Visible = false;
            pictureBoxComputersCard.Visible = false;
        }

        private void textBoxBet_TextChanged(object sender, EventArgs e) {
           
        }

        private void BiggerCard_Load(object sender, EventArgs e) {
            var dbUserNew = new EFDbNewUserEntities1();
            
        }

        private void buttonDrawYourCard_Click(object sender, EventArgs e) {
            textBoxDrawYourCard.Text = yourCard.ToString();
            pictureBoxPlayersCard.Visible = true;
            pictureBoxPlayersCard.Image = Resource1.ace_of_hearts;

        }

        private void textBoxDrawComputersCard_TextChanged(object sender, EventArgs e) {

        }

        private void buttonDrawComputerCard_Click(object sender, EventArgs e) {
            
            textBoxDrawComputersCard.Text = compCard.ToString();
            pictureBoxComputersCard.Visible = true;
            pictureBoxComputersCard.Image = Resource1.jack_of_diamonds;
            if (compCard > yourCard) { textBoxPlayerStatus.Text = "You lose";
            } else if (compCard < yourCard) {
                textBoxPlayerStatus.Text = "You win";
            }else textBoxPlayerStatus.Text = "Noone wins";
        }

        private void textBoxPlayerStatus_TextChanged(object sender, EventArgs e) {
            int bet = int.Parse(textBoxBet.Text);
            int balance = int.Parse(textBoxBigCardUserBalance.Text);
            int result;
            int CurrentBalance(int ba, int be) {
               var currentBalance = 0;
            switch(textBoxPlayerStatus.Text) {
               case "You win": return currentBalance = ba + be; break;
                   case "You lose": return currentBalance =  ba - be; break;
                    case "Noone wins": return currentBalance = ba; break;
            }
                return currentBalance;
            }
            result = CurrentBalance(balance, bet);
           // result = balance + bet;
            textBoxBigCardUserBalance.Text = result.ToString();
            using(var dbUserNew = new EFDbNewUserEntities1()) {
                int currentBalanceValue = int.Parse(textBoxBigCardUserBalance.Text);
                string currentBiggerCardUser = textBoxBigCardUsername.Text;
                var bigCardCurrentBalance = new UserNew {
                    UserNewName = currentBiggerCardUser,
                    UserNewBalance = currentBalanceValue
                };
                dbUserNew.UserNews.Add(bigCardCurrentBalance);
                dbUserNew.SaveChanges();
            }
           
        }

        private void pictureBoxPlayersCard_Click(object sender, EventArgs e) {

        }

        private void textBoxDrawYourCard_TextChanged(object sender, EventArgs e) {

        }
    }
}
